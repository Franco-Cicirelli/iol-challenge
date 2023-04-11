using CodingChallenge.Data;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Reporte;
using CodingChallenge.Data.Resources.Constants.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Reporte.Frances
{
    public class ReporteFrances : IReporte
    {
        public string Imprimir(List<FormaGeometrica> formas)
        {
            ReporteTemplate reporteCastellano = new ReporteTemplate(
                TemplateFrances.LISTA_VACIA_FRANCES,
                TemplateFrances.REPORTES_FORMAS_FRANCES,
                TemplateFrances.FORMAS_FRANCES,
                TemplateFrances.PERIMETRO_FRANCES,
                TemplateFrances.TOTAL_FRANCES,
                TemplateFrances.AREA_FRANCES);

            return Reporte.CrearTemplateBaseDeReportes(formas, reporteCastellano, Languages.Frances);
        }
    }
}
