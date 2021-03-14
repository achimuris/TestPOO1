using Microsoft.VisualStudio.TestTools.UnitTesting;
using POO.Clases.Ejercicio02;

namespace POO.Tests
{
    [TestClass]
    public class UnitTestEjercicio2
    {

        [TestMethod]
        public void TestMethodSinPromedio()
        {
            /*Resultados esperados*/
            double resultadoEsperado = -1;

            /*Ejecución*/
            Plato objPlato = new Plato
            {
                Nombre = "Milanesas con papas fritas"
            };

            /*Assert - Prueba*/
            Assert.AreEqual(resultadoEsperado, objPlato.getOpinionPromedio());
        }


        [TestMethod]
        public void TestMethodPromedioSimple1()
        {
            double resultadoEsperado = 7;


            Plato objPlato = new Plato();
            objPlato.Nombre = "Milanesas con papas fritas";
            objPlato.AgregarOpinion(6);
            objPlato.AgregarOpinion(7);
            objPlato.AgregarOpinion(8);


            Assert.AreEqual(resultadoEsperado, objPlato.getOpinionPromedio());
        }

        [TestMethod]
        public void TestMethodPromedioSimple2()
        {
            double resultadoEsperado = 3;


            Plato objPlato = new Plato();
            objPlato.Nombre = "Milanesas con papas fritas";
            objPlato.AgregarOpinion(2);
            objPlato.AgregarOpinion(4);


            Assert.AreEqual(resultadoEsperado, objPlato.getOpinionPromedio());
        }


        [TestMethod]
        public void TestMethodNombreConConstructorGenerico()
        {
            Plato objPlato = new Plato();
            objPlato.Nombre = "Milanesas con papas fritas";

            Assert.AreEqual("Milanesas con papas fritas", objPlato.Nombre);

        }

        [TestMethod]
        public void TestMethodNombreConConstructorEspecializado()
        {
            Plato objPlato = new Plato("Pollo a la parrilla", 5);

            Assert.AreEqual("Pollo a la parrilla", objPlato.Nombre);

        }

        /// <summary>
        /// TestMethodPrecioEscenario1() cantidad de ingredientes = 5
        /// precio base = 150
        /// precio ingredientes (por tener más de 3), 5 * 30 = 150
        /// Debe retornar 300
        /// </summary>
        [TestMethod]
        public void TestMethodPrecioEscenario1()
        {

            double resultadoEsperado = 300;
            Plato objPlato = new Plato("Pollo a la parrilla", 5);

            Assert.AreEqual(resultadoEsperado, objPlato.getPrecio());

        }
    }
}
