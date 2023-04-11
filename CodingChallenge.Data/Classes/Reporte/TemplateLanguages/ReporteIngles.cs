using CodingChallenge.Data.Resources.Constants.Templates;
using System.Collections.Generic;

namespace CodingChallenge.Data.Classes.Reporte.Ingles
{
    public class ReporteIngles : IReporte
    {
        public string Imprimir(List<FormaGeometrica> formas)
        {
            // Generar reporte en inglés
            ReporteTemplate reporteIngles = new ReporteTemplate(
                TemplateIngles.LISTA_VACIA_INGLES ,
                TemplateIngles.REPORTES_FORMAS_INGLES,
                TemplateIngles.FORMAS_INGLES,
                TemplateIngles.PERIMETRO_INGLES,
                TemplateIngles.TOTAL_INGLES,
                TemplateIngles.AREA_INGLES);

            return Reporte.CrearTemplateBaseDeReportes(formas, reporteIngles, Languages.Ingles);
        }
    }
}
