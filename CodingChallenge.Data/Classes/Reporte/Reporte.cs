
using CodingChallenge.Data.Resources.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Reporte
{
    public static class Reporte 
    {
        public static string CrearTemplateBaseDeReportes(List<FormaGeometrica> formas, ReporteTemplate template , Languages language)
        {
            if (!formas.Any())
            {
                return template.EmptyListMessage;
            }

            var formaCounts = new Dictionary<string, int>();
            var formaAreas = new Dictionary<string, decimal>();
            var formaPerimetros = new Dictionary<string, decimal>();

            foreach (var forma in formas)
            {
                var tipo = forma.GetType().Name.ToString();

                if (!formaCounts.ContainsKey(tipo))
                {
                    formaCounts[tipo] = 0;
                    formaAreas[tipo] = 0m;
                    formaPerimetros[tipo] = 0m;
                }

                formaCounts[tipo]++;
                formaAreas[tipo] += forma.CalcularArea();
                formaPerimetros[tipo] += forma.CalcularPerimetro();
            }

            var sb = new StringBuilder();
            sb.Append(template.Header);

            foreach (var keyValue in formaCounts)
            {
                var tipo = keyValue.Key;
                var cantidad = keyValue.Value;
                var area = formaAreas[tipo];
                var perimetro = formaPerimetros[tipo];

                sb.Append(FigurasGeometricaTraductor.ObtenerLinea(cantidad, language,  area, perimetro, GetForma(tipo)));
            }

            // FOOTER
            sb.Append(template.Total);
            sb.Append($"{formaCounts.Values.Sum()} {template.Formas} "); 
            sb.Append($"{template.Perimeter}{formaPerimetros.Values.Sum().ToString("#.##")} ");
            sb.Append($"{template.Area}{formaAreas.Values.Sum().ToString("#.##")}");

            return sb.ToString();
        }

        // Obtengo la forma del elemento que paso por parametro
        private static Formas GetForma(string tipo)
        {
            foreach (Formas forma in Enum.GetValues(typeof(Formas)))
            {
                if (tipo.Equals(forma.ToString()))
                {
                    return forma;
                }
            }

            return Formas.FormaInvalida;
        }
    }


}
