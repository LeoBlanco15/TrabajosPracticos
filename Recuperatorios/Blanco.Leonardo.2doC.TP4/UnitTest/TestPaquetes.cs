using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTest
{
    [TestClass]
    public class TestPaquetes
    {
        [TestMethod]
        public void Test_PaquetesEmpty()
        {
            Correo aux = new Correo();


            Assert.IsNotNull(aux.Paquetes);
        }
        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoExeption))]
        public void Test_PaquetesIguales()
        {
            Correo correo = new Correo();
            Paquete paqueteUno = new Paquete("Palermo 550", "3534");
            Paquete paqueteDos = new Paquete("New Street 350", "3534");

            correo += paqueteUno;
            correo += paqueteDos;
        }
    }
}
