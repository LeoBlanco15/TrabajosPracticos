using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exepciones;
using Instanciables;
using EntidadesAbstractas;

namespace Test_unitario
{
    [TestClass]
    public class TestExtras
    {
        [TestMethod]
        public void Test_ValidacionNombres()
        {
            Alumno alumno = new Alumno(1, "??????", "Peposo", "1234567", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            string spected = "";

            Assert.AreEqual(alumno.Nombre, spected);
        }
        [TestMethod]
        public void Test_ValidacionApellido()
        {
            Alumno alumno = new Alumno(1, "Pepe", "?????", "1234567", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            string spected = "";

            Assert.AreEqual(alumno.Apellido, spected);
        }
    }
}
