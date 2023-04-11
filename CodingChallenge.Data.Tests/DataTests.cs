using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Reporte;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                ReporteFactory.Imprimir(new List<FormaGeometrica>(), Languages.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                ReporteFactory.Imprimir(new List<FormaGeometrica>(), Languages.Ingles));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnFrances()
        {
            Assert.AreEqual("<h1>Liste de formes vide!</h1>",
                ReporteFactory.Imprimir(new List<FormaGeometrica>(), Languages.Frances));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> {new Cuadrado(5)};

            var resumen = ReporteFactory.Imprimir(cuadrados, Languages.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioEnFrances()
        {
            var cuadrados = new List<FormaGeometrica> { new Trapecio(5,2, 3) };

            var resumen = ReporteFactory.Imprimir(cuadrados, Languages.Frances);

            Assert.AreEqual("<h1>Rapport de formulaires</h1>1 Trapèze | Zone 25 | Périmètre 15 <br/>TOTAL:<br/>1 formes Périmètre 15 Zone 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectanguloEnFrances()
        {
            var cuadrados = new List<FormaGeometrica> { new Rectangulo(5, 10) };

            var resumen = ReporteFactory.Imprimir(cuadrados, Languages.Frances);

            Assert.AreEqual("<h1>Rapport de formulaires</h1>1 Rectangle | Zone 50 | Périmètre 30 <br/>TOTAL:<br/>1 formes Périmètre 30 Zone 50", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado( 5),
                new Cuadrado( 1),
                new Cuadrado( 3)
            };

            var resumen = ReporteFactory.Imprimir(cuadrados, Languages.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado( 5),
                new Circulo( 3),
                new TrianguloEquilatero( 4),
                new Cuadrado( 2),
                new TrianguloEquilatero( 9),
                new Circulo( 2.75m),
                new TrianguloEquilatero( 4.2m)
            };

            var resumen = ReporteFactory.Imprimir(formas, Languages.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado( 5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado( 2),
                new TrianguloEquilatero( 9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = ReporteFactory.Imprimir(formas, Languages.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaTodosLosTiposEnIngles()
        {
            var formas = new List<FormaGeometrica>
             {
             new Cuadrado( 5),
             new Circulo( 3),
             new TrianguloEquilatero( 4),
             new Cuadrado( 2),
             new TrianguloEquilatero( 9),
             new Circulo( 2.75m),
             new TrianguloEquilatero( 4.2m),
             new Rectangulo(5, 10),
             new Trapecio(5,2, 3)
             };

            var resumen = ReporteFactory.Imprimir(formas, Languages.Ingles);

            Assert.AreEqual(
            "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>1 Rectangle | Area 50 | Perimeter 30 <br/>1 Trapeze | Area 25 | Perimeter 15 <br/>TOTAL:<br/>9 shapes Perimeter 142,66 Area 166,65",
            resumen);
        }
    }
}
