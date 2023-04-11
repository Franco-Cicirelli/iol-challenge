using CodingChallenge.Data.Classes.Reporte.Español;
using CodingChallenge.Data.Classes.Reporte.Frances;
using CodingChallenge.Data.Classes.Reporte.Ingles;
using System;
using System.Collections.Generic;

namespace CodingChallenge.Data.Classes.Reporte
{
    public class ReporteFactory
    {
        public static IReporte CrearReporte(Languages language)
        {
            switch (language)
            {
                case Languages.Castellano:
                    return new ReporteCastellano();
                case Languages.Ingles:
                    return new ReporteIngles();
                case Languages.Frances:
                    return new ReporteFrances();
                default:
                    throw new ArgumentException("Idioma no soportado.");
            }
        }

        public static string Imprimir(List<FormaGeometrica> formas, Languages language)
        {
            
            var reporte = CrearReporte(language);
            return reporte.Imprimir(formas);
        }
    }
}
