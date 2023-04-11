
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Data.Resources.Constants.Templates;
using CodingChallenge.Data.Resources.Enums;

namespace CodingChallenge.Data.Classes.Reporte.Español
{
    public class ReporteCastellano : IReporte
    {
        public string Imprimir(List<FormaGeometrica> formas)
        {
            ReporteTemplate reporteCastellano = new ReporteTemplate(
                TemplateEspanol.LISTA_VACIA_ESPANOL,
                TemplateEspanol.REPORTES_FORMAS_ESPANOL,
                TemplateEspanol.FORMAS_ESPANOL,
                TemplateEspanol.PERIMETRO_ESPANOL,
                TemplateEspanol.TOTAL_ESPANOL,
                TemplateEspanol.AREA_ESPANOL);

            return Reporte.CrearTemplateBaseDeReportes(formas, reporteCastellano, Languages.Castellano);
        }
    }
}
