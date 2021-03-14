using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace POO.Tests
{
    [TestClass]
    public class UnitTestEjercicio1
    {
        [TestMethod]
        public void TestMethodNombreConConstructorGenerico()
        {
            POO.Clases.Ejercicio01.Plato objPlato = new Clases.Ejercicio01.Plato();
            objPlato.Nombre = "Milanesas con papas fritas";

            Assert.AreEqual("Milanesas con papas fritas", objPlato.Nombre);

        }

        [TestMethod]
        public void TestMethodNombreConConstructorEspecializado()
        {
            POO.Clases.Ejercicio01.Plato objPlato = new Clases.Ejercicio01.Plato("Pollo a la parrilla", 5);

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
            POO.Clases.Ejercicio01.Plato objPlato = new Clases.Ejercicio01.Plato("Pollo a la parrilla", 5);

            Assert.AreEqual(resultadoEsperado, objPlato.getPrecio());

        }
    }
}
