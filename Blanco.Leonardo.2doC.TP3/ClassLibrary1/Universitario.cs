using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;
        //--------------------------------------------------------------------------------------------
        #region constructores
        /// <summary>
        /// constructor por defecto, inicializa todo en 1, nada y argenino
        /// </summary>
        public Universitario() : this(1, "", "", "1", ENacionalidad.Argentino){}
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, nacionalidad, dni)
        {
            this.legajo = legajo;
        }
        #endregion
        //--------------------------------------------------------------------------------------------
        #region metodos
        /// <summary>
        /// Metodo abstracto para clases derivadas
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();
        /// <summary>
        /// Override de Equal que dice si la instancia y otro universitario son iguales comparando legajo y DNI
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (((Universitario)obj).DNI == this.DNI || ((Universitario)obj).legajo == this.legajo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Devuelve en string los datos del universitario
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("Legajo: {0}\n", this.legajo);
            return sb.ToString();
        }
        #endregion
        //--------------------------------------------------------------------------------------------
        #region operaciones
        /// <summary>
        /// Checkea si dos universitarios son diferentes (usa el override de Equal)
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="u2"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario u1, Universitario u2)
        {
            return !(u1.Equals(u2));
        }
        /// <summary>
        /// Checkea si dos universitarios son iguales (usa el override de Equal)
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="u2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario u1, Universitario u2)
        {
            return u1.Equals(u2);
        }
        #endregion
    }
}
