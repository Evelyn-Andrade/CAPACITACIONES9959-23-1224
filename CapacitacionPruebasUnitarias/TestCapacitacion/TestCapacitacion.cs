using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapacitacionPruebasUnitarias;

namespace TestCapacitacion
{
    [TestClass]
    public class TestDescuentoPlanilla
    {
        [TestMethod]
        public void Test_Descuento_10PorCiento_DevuelveLaMitadDeSalario()
        {
            //Arrange: salario de 1000 y descuento de 10%
            var Calculadora = new ClsDescuentoPlanilla();
            //Act: calcular el descuento
            decimal Descuento = Calculadora.CalcularDescuento(1000m, 10m);
            //Assert: debe ser 100
            Assert.AreEqual(100m, Descuento);
        }

        [TestMethod]
        public void Test_SalarioNeto_1000Con10PorCiento_Devuelve900()
        {
            //Arrange: salario de 1000 y descuento de 10%
            var Calculadora = new ClsDescuentoPlanilla();
            //Act: calcular el salario neto
            decimal Neto = Calculadora.CalcularSalarioNeto(1000m, 10m);
            //Assert: debe ser 900
            Assert.AreEqual(900m, Neto);
        }

        [TestMethod]
        public void Test_Descuento_PorcentajeCero_NoDescuentaNada()
        {
            //Arrange: descuento de 0%
            var Calculadora = new ClsDescuentoPlanilla();
            //Act: calcular el descuento
            decimal Descuento = Calculadora.CalcularDescuento(1000m, 0m);
            //Assert: debe ser 0
            Assert.AreEqual(0m, Descuento);
        }
    }
}