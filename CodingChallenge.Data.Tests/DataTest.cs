using CodingChallenge.Data.Clases;
using CodingChallenge.Data.Interfaces;
using NUnit.Framework;
using CodingChallenge.Data.Idiomas;
using CodingChallenge.Data.Models;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTest
    {

        [TestCase]
        public void TestResumenListaVaciaCastellano()
        {
            string descripcion = FormasGeometricas.Imprimir(new List<IFormas>(), Lenguaje.CASTELLANO);
            Assert.AreEqual("La lista no contiene formas geometricas\r\n", descripcion);
        }
        [TestCase]
        public void TestResumenListaVaciaEnglish()
        {
            string descripcion = FormasGeometricas.Imprimir(new List<IFormas>(), Lenguaje.ENGLISH);
            Assert.AreEqual("List does not contain geometric forms\r\n", descripcion);
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            List<IFormas> formas = new List<IFormas>();
            formas.Add(new Cuadrado() { _cantidad = 1, _lado = 5 });

            string descripcion = FormasGeometricas.Imprimir(formas, Lenguaje.CASTELLANO);
            Assert.AreEqual("Reporte de Formas Geometricas\r\n1 Cuadrado | Area: 25 | Perimetro 20 \r\nTotal:Hay 1 Forma Geometrica\r\nArea Total: 25\r\nPerimetro Total: 20", descripcion);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IFormas>
            {
                new Cuadrado() { _cantidad = 1, _lado = 5 },
                new Cuadrado() { _cantidad = 1, _lado = 1 },
                new Cuadrado() { _cantidad = 1, _lado = 3 }
            };

            string descripcion = FormasGeometricas.Imprimir(cuadrados, Lenguaje.ENGLISH);

            Assert.AreEqual("Shapes report\r\n1 Square | Area: 25 | Perimeter 20 \r\n1 Square | Area: 1 | Perimeter 4 \r\n1 Square | Area: 9 | Perimeter 12 \r\nTotal:There are 3 shapes.\r\nTotal area: 35\r\nTotal perimeter: 36", descripcion);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<IFormas>
            {
                new Cuadrado(){ _cantidad = 1, _lado = 5 },
                new Circulo(){ _cantidad = 1, _lado = 3 },
                new Triangulo(){ _cantidad = 1, _lado = 4 },
                new Cuadrado(){ _cantidad = 1, _lado = 2 },
                new Triangulo(){ _cantidad = 1, _lado = 9 },
                new Circulo(){ _cantidad = 1, _lado = 2.75m },
                new Triangulo(){ _cantidad = 1, _lado = 4.2m }
            };

            string descripcion = FormasGeometricas.Imprimir(formas, Lenguaje.ENGLISH);

            Assert.AreEqual(
                "Shapes report\r\n1 Square | Area: 25 | Perimeter 20 \r\n1 Circle | Area: 7,07 | Perimeter 9,42 \r\n1 Triangle | Area: 6,93 | Perimeter 12 \r\n1 Square | Area: 4 | Perimeter 8 \r\n1 Triangle | Area: 35,07 | Perimeter 27 \r\n1 Circle | Area: 5,94 | Perimeter 8,64 \r\n1 Triangle | Area: 7,64 | Perimeter 12,6 \r\nTotal:There are 7 shapes.\r\nTotal area: 91,65\r\nTotal perimeter: 97,66",
                descripcion);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormas>
            {
                new Cuadrado(){ _cantidad = 1, _lado = 5 },
                new Circulo(){ _cantidad = 1, _lado = 3 },
                new Triangulo(){ _cantidad = 1, _lado = 4 },
                new Cuadrado(){ _cantidad = 1, _lado = 2 },
                new Triangulo(){ _cantidad = 1, _lado = 9 },
                new Circulo(){ _cantidad = 1, _lado = 2.75m },
                new Triangulo(){ _cantidad = 1, _lado = 4.2m }
            };

            string descripcion = FormasGeometricas.Imprimir(formas, Lenguaje.CASTELLANO);

            Assert.AreEqual(
                "Reporte de Formas Geometricas\r\n1 Cuadrado | Area: 25 | Perimetro 20 \r\n1 Circulo | Area: 7,07 | Perimetro 9,42 \r\n1 Triangulo | Area: 6,93 | Perimetro 12 \r\n1 Cuadrado | Area: 4 | Perimetro 8 \r\n1 Triangulo | Area: 35,07 | Perimetro 27 \r\n1 Circulo | Area: 5,94 | Perimetro 8,64 \r\n1 Triangulo | Area: 7,64 | Perimetro 12,6 \r\nTotal:Hay 7 Formas Geometricas\r\nArea Total: 91,65\r\nPerimetro Total: 97,66",
                descripcion);
        }
    }
}