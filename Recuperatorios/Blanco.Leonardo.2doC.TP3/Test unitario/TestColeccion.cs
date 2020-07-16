using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exepciones;
using Instanciables;
using EntidadesAbstractas;

namespace Test_unitario
{
    [TestClass]
    public class TestColeccion
    {
        [TestMethod]
        public void Test_Universidad_InstanciaAlumnos()
        {
            Universidad uni = new Universidad();

            Assert.IsNotNull(uni.Alumnos);
        }
        [TestMethod]
        public void Test_Universidad_InstanciaInstructores()
        {
            Universidad uni = new Universidad();

            Assert.IsNotNull(uni.Instructores);
        }
        [TestMethod]
        public void Test_Universidad_InstanciaJornada()
        {
            Universidad uni = new Universidad();

            Assert.IsNotNull(uni.Jornadas);
        }
    }
}
