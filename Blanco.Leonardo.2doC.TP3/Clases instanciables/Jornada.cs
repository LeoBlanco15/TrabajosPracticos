using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Abstractas;
using Archivos;
using Exepciones;

namespace Instanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        //--------------------------------------------------------------------------------------------
        #region propiedades
        /// <summary>
        /// Propiedad {set; get;} de la lista de alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }
        /// <summary>
        /// Propiedad {get; set;} que maneja que enum de clase tiene la jornada
        /// </summary>
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }
        /// <summary>
        /// Propiedad{get; set;} que maneja el profesor de la jornada
        /// </summary>
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        #endregion
        //--------------------------------------------------------------------------------------------
        #region constructores
        /// <summary>
        /// constructor privado, inicializa la lista de alumnos
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }
        /// <summary>
        /// Constructor con todos sus parametros
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }
        #endregion
        //--------------------------------------------------------------------------------------------
        #region metodos
        /// <summary>
        /// Metodo estatico para guardar el contenido de la jornada en un archivo de texto
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto aux = new Texto();
            //al llamar al metodo guardar de Texto ya escribe en el texto
            //PD: ninguno de los paths en mi pc tienen permiso
            try
            {
                return aux.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), jornada.ToString());
            }
            catch (ArchivosException e)
            {

                throw e;
            }
        }
        /// <summary>
        /// Metodo que lee de un archivo de texto
        /// </summary>
        /// <returns></returns>
        public string Leer()
        {
            Texto aux = new Texto();
            string ret = "";
            //al llamar al metodo leer de Texto ya lee en el texto
            //PD: ninguno de los paths en mi pc tienen permiso
            try
            {
                aux.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), out ret);
                return ret;
            }
            catch (ArchivosException e)
            {

                throw e;
            }
        }
        /// <summary>
        /// Metodo para hacer publicos los atributos de la jornada
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("JORNADA: ");
            sb.AppendFormat("Clase de {0}\n", this.Clase);
            sb.AppendFormat("Profesor: {0}\n", this.Instructor.ToString());
            sb.AppendLine("ALUMNOS: ");
            foreach (Alumno item in this.Alumnos)
            {
                sb.Append(item.ToString());
                sb.AppendLine("");
            }
            sb.AppendLine("-------------------------------------------------------------");


            return sb.ToString();
        }
        #endregion
        //--------------------------------------------------------------------------------------------
        #region operaciones
        /// <summary>
        /// Operador para agregar un alumno a la jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.Alumnos.Add(a);
            }
            return j;
        }
        /// <summary>
        /// Operador para ver si un alumno esta en la jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Alumno item in j.Alumnos)
            {
                if (a == item)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Operador para ver si un alumno no esta en la jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            foreach (Alumno item in j.Alumnos)
            {
                if (a == item)
                {
                    return false ;
                }
            }
            return true;
        }
        #endregion
    }
}
