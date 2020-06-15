using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exepciones;
using Instanciables;
using EntidadesAbstractas;

namespace Test_unitario
{
    [TestClass]
    public class TestExeptions
    {
        [TestMethod]
        [ExpectedException (typeof(DniInvalidoExeption))]
        public void Test_DNIConLetroa()
        {
            Alumno alumno = new Alumno(1, "Pepe", "Peposo", "1234567a", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
        }

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoExeption))]
        public void Test_DNIMuyLargo()
        {
            Alumno alumno = new Alumno(1, "Pepe", "Peposo", "1234567891", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
        }
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void Test_NacionalidadInvalida()
        {
            Alumno alumno = new Alumno(1, "Pepe", "Peposo", "12345678", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
        }
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void Test_NacionalidadInvalida2()
        {
            Alumno alumno = new Alumno(1, "Pepe", "Peposo", "92345678", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
        }
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void Test_MismoDNI()
        {
            Universidad uni = new Universidad();
            Alumno alumno = new Alumno(1, "Pepe", "Peposo", "1234567", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno alumno2 = new Alumno(2, "Jose", "Stronghold", "1234567", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            uni += alumno;
            uni += alumno2;
        }
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void Test_MismoLegajo()
        {
            Universidad uni = new Universidad();
            Alumno alumno = new Alumno(1, "Pepe", "Peposo", "1234567", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno alumno2 = new Alumno(1, "Jose", "Stronghold", "12345678", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            uni += alumno;
            uni += alumno2;
        }
        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void Test_LeerTexto()
        {
            Jornada jornada = new Jornada(Universidad.EClases.Programacion, new Profesor());

            jornada.Leer();
        }
        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void Test_GuardarTexto()
        {
            Jornada jornada = new Jornada(Universidad.EClases.Programacion, new Profesor());

            Jornada.Guardar(jornada);
        }
        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void Test_LeerXml()
        {
            Universidad uni = new Universidad();
            uni.Leer();
        }
        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void Test_GuardarXml()
        {
            Universidad uni = new Universidad();
            Alumno alumno = new Alumno(1, "Pepe", "Peposo", "1234567", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno alumno2 = new Alumno(2, "Jose", "Stronghold", "12345678", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            uni += alumno;
            uni += alumno2;

            Universidad.Guardar(uni);
        }
    }
}
