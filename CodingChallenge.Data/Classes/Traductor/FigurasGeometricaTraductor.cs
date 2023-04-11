using CodingChallenge.Data.Resources.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public static class FigurasGeometricaTraductor
    {
        public static string ObtenerLinea(int cantidad, Languages idioma, decimal area, decimal perimetro, Formas tipo)
        {
            if (cantidad > 0)
            {
                switch (idioma)
                {
                    case Languages.Castellano:
                        return $"{cantidad} {TraducirForma(cantidad, idioma, tipo)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
                    case Languages.Ingles:
                        return $"{cantidad} {TraducirForma(cantidad, idioma, tipo)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
                    case Languages.Frances:
                        return $"{cantidad} {TraducirForma(cantidad, idioma, tipo)} | Zone {area:#.##} | Périmètre {perimetro:#.##} <br/>";
                }
            }

            return string.Empty;
        }

        private static string TraducirForma(int cantidad, Languages idioma, Formas tipo)
        {
            Dictionary<Formas, string[]> traducciones = Traducciones(idioma);
            traducciones.TryGetValue(tipo, out string[] formaTraducciones);

            if (formaTraducciones == null)
            {
                return null;
            }

            string singular = formaTraducciones[0];
            string plural = formaTraducciones[1];

            return cantidad > 1 ? plural : singular;
        }

        private static Dictionary<Formas, string[]> Traducciones(Languages idioma)
        {
            Dictionary<Formas, string[]> traducciones = new Dictionary<Formas, string[]>();

            switch (idioma)
            {
                case Languages.Castellano:
                    traducciones.Add(Formas.Cuadrado, new[] { "Cuadrado", "Cuadrados" });
                    traducciones.Add(Formas.Circulo, new[] { "Círculo", "Círculos" });
                    traducciones.Add(Formas.TrianguloEquilatero, new[] { "Triángulo", "Triángulos" });
                    traducciones.Add(Formas.Rectangulo, new[] { "Rectangulo", "Rectangulos" });
                    traducciones.Add(Formas.Trapecio, new[] { "Trapecio", "Trapecios" });
                    break;
                case Languages.Ingles:
                    traducciones.Add(Formas.Cuadrado, new[] { "Square", "Squares" });
                    traducciones.Add(Formas.Circulo, new[] { "Circle", "Circles" });
                    traducciones.Add(Formas.TrianguloEquilatero, new[] { "Triangle", "Triangles" });
                    traducciones.Add(Formas.Rectangulo, new[] { "Rectangle", "Rectangles" });
                    traducciones.Add(Formas.Trapecio, new[] { "Trapeze", "Trapezoids" });
                    break;
                case Languages.Frances:
                    traducciones.Add(Formas.Cuadrado, new[] { "Carré", "Carrés" });
                    traducciones.Add(Formas.Circulo, new[] { "Cercle", "Cercles" });
                    traducciones.Add(Formas.TrianguloEquilatero, new[] { "Triangle", "Triangles" });
                    traducciones.Add(Formas.Rectangulo, new[] { "Rectangle", "Rectangles" });
                    traducciones.Add(Formas.Trapecio, new[] { "Trapèze", "Trapèzes" });
                    break;
            }

            

            return traducciones;
        }

        
    }
}
