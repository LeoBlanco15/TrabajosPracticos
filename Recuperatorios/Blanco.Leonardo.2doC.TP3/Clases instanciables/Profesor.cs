using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Instanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;
        //--------------------------------------------------------------------------------------------
        #region constructores
        /// <summary>
        /// Constructor estatico que inicializa el random
        /// </summary>
        static Profesor()
        {
            Profesor.random = new Random();
        }
        /// <summary>
        /// Constructor por defecto, inicializa a todo por defecto
        /// </summary>
        public Profesor() :this(1, "", "", "1", ENacionalidad.Argentino) { }
        /// <summary>
        /// Constructor con todos los parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }
        #endregion
        //--------------------------------------------------------------------------------------------
        #region metodos
        /// <summary>
        /// metodo para asignar las materias aleatoriamente a un profesor
        /// </summary>
        private void _randomClases()
        {
            for (int i = 0; i < 2; i++)
            {
                this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0,3));
            }
        }
        /// <summary>
        /// Metodo para hacer publicos los atributos del profesor
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        /// <summary>
        /// Metodo que devuelve string con las clases que tiene el profesor
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA");
            foreach (Universidad.EClases item in this.clasesDelDia)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// convierte todos los atributos de un profesor en string
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.Append(this.ParticiparEnClase());

            return sb.ToString();
        }
        #endregion
        //--------------------------------------------------------------------------------------------
        #region operaciones
        /// <summary>
        /// Operador para ver si un profesor no da una clase
        /// </summary>
        /// <param name="p"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator !=(Profesor p, Universidad.EClases c)
        {
            foreach (Universidad.EClases item in p.clasesDelDia)
            {
                if (item == c)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Operador para ver si un profesor da una clase
        /// </summary>
        /// <param name="p"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator ==(Profesor p, Universidad.EClases c)
        {
            foreach (Universidad.EClases item in p.clasesDelDia)
            {
                if (item == c)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}