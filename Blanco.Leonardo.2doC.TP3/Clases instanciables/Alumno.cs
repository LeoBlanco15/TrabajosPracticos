using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Instanciables
{
    public sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        private Universidad.EClases clasesQueToma;
        private EEstadoCuenta estadoCuenta;
        //--------------------------------------------------------------------------------------------
        #region constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Alumno() :this(1, "", "", "1", ENacionalidad.Argentino, Universidad.EClases.Laboratorio) {}
        /// <summary>
        /// Constructor sin estado de cuenta, que es rellenada al dia
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) 
            :this(id, nombre, apellido, dni, nacionalidad, claseQueToma, EEstadoCuenta.AlDia){}
        /// <summary>
        /// Constructor con todos los campos como parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesQueToma = claseQueToma;
            this.estadoCuenta = estadoCuenta;
        }
        #endregion
        //--------------------------------------------------------------------------------------------
        #region metodos
        /// <summary>
        /// Retorna un string con todos los campos del Alumno, es override de el original en Universitario
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.Append(this.ParticiparEnClase());
            sb.AppendFormat("Estado de cuenta: {0}", this.estadoCuenta);
            sb.AppendLine("");

            return sb.ToString();
        }
        /// <summary>
        /// Metodo para hacer publicos los atributos de al alumno, usa MostrarDatos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        /// <summary>
        /// Muestra en que clase esta el alumno, override de la clase abstracta en Universitario
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Toma clase de: {0} \n", this.clasesQueToma);
            return sb.ToString();
        }
        #endregion
        //--------------------------------------------------------------------------------------------
        #region operaciones
        /// <summary>
        /// Retorna true si un alumno no toma la clase dada como parametro
        /// </summary>
        /// <param name="a"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Universidad.EClases e)
        {
            return a.clasesQueToma != e;
        }
        /// <summary>
        /// Retorna true si el alumno toma la clase dada como parametro
        /// </summary>
        /// <param name="a"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, Universidad.EClases e)
        {
            return (a.clasesQueToma == e && a.estadoCuenta != EEstadoCuenta.Deudor);
        }
        #endregion
    }
}
