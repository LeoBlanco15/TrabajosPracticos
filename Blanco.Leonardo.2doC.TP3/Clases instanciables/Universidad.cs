using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Exepciones;
using Archivos;

namespace Instanciables
{
    public class Universidad
    {
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
        private List<Alumno> alumnos;
        private List<Jornada> jornadas;
        private List<Profesor> profesores;
        //--------------------------------------------------------------------------------------------
        #region Propiedades
        /// <summary>
        /// Propiedad para controlar la lista de alumnos
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
        /// Propiedad para controlar la lista de jornadas
        /// </summary>
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornadas;
            }
            set
            {
                this.jornadas = value;
            }
        }
        /// <summary>
        /// Propiedad para controlar la lista de profesores
        /// </summary>
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }
        /// <summary>
        /// Propiedad para controlar con un indexador la lista de jornadas
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Jornada this[int i]
        {
            get
            {
                return this.Jornadas[i];
            }
            set
            {
                this.Jornadas[i] = value;
            }
        }
        #endregion
        //--------------------------------------------------------------------------------------------
        #region constructores
        /// <summary>
        /// Unico constructor de universidad, inicaliza a todas las listas que tiene esta
        /// </summary>
        public Universidad()
        {
            this.Jornadas = new List<Jornada>();
            this.Instructores = new List<Profesor>();
            this.Alumnos = new List<Alumno>();
        }
        #endregion
        //--------------------------------------------------------------------------------------------
        #region operaciones
        /// <summary>
        /// Operador para determinar si un alumno no esta en la universidad
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad u, Alumno a)
        {
            foreach (Alumno item in u.Alumnos)
            {
                if (item == a)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Operador para determinar si un profesor no trabaja en la universidad
        /// </summary>
        /// <param name="u"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad u, Profesor p)
        {
            foreach (Profesor item in u.Instructores)
            {
                if (item == p)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Operador que devuelve el primer profesor que no este en la clase pasada por parametro
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor item in u.Instructores)
            {
                if (item != clase)
                {
                    return item;
                }
            }
            throw new SinProfesorException();
        }
        /// <summary>
        /// Operador para determinar si un alumno esta en la universidad
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad u, Alumno a)
        {
            return !(u!=a);
        }
        /// <summary>
        /// Operador para determinar si un profesor trabaja en la universidad
        /// </summary>
        /// <param name="u"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad u, Profesor p)
        {
            return !(u!=p);
        }
        /// <summary>
        /// Operador que devuelve el primer profesor que este en la clase pasada por parametro
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor item in u.Instructores)
            {
                if (item == clase)
                {
                    return item;
                }
            }
            throw new SinProfesorException();
        }
        /// <summary>
        /// Operador que agrega una jornada a la lista con la clase pasada como parametro, el profesor que puede dar esa clase
        /// y los alumnos que estan en esa materia
        /// </summary>
        /// <param name="u"></param>
        /// <param name="e"></param>
        /// <returns>
        /// Universidad
        /// </returns>
        public static Universidad operator +(Universidad u, EClases e)
        {
            List<Alumno> auxAlumnos = new List<Alumno>();
            Jornada ret = new Jornada(e, u==e);

            foreach (Alumno item in u.Alumnos)
            {
                if (item == e)
                {
                    auxAlumnos.Add(item);
                }
            }
            ret.Alumnos = auxAlumnos;
            u.Jornadas.Add(ret);
            return u;
        }
        /// <summary>
        /// Operador que agrega un alumno a la universidad si no es que ya esta
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u!=a)
            {
                u.Alumnos.Add(a);
                return u;
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            
        }
        /// <summary>
        /// Operador que agrega un porfesor a la universidad si no esta ya
        /// </summary>
        /// <param name="u"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, Profesor p)
        {
            if (u!=p)
            {
                u.Instructores.Add(p);
            }
            return u;
        }
        #endregion
        //--------------------------------------------------------------------------------------------
        #region metodos
        /// <summary>
        /// metodo privado estatico para mostrar una universidad
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        private static string MostrarDatos(Universidad u)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Jornada item in u.Jornadas)
            {
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// etodo para hacer publicos los atributos de la universidad, usa MostrarDatos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
        /// <summary>
        /// Metodo para leer un archivo Xml y retorna la universidad leida
        /// </summary>
        /// <returns></returns>
        public Universidad Leer()
        {
            Universidad universidad = this;
            Xml<Universidad> aux = new Xml<Universidad>();

            ////PD: ninguno de los paths en mi pc tienen permiso
            if (aux.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), out universidad))
            {
                return universidad;
            }
            else
            {
                return universidad;
            }
        }
        /// <summary>
        /// Metodo para guardar los archivos en un archivo Xml
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> aux = new Xml<Universidad>();

            ////PD: ninguno de los paths en mi pc tienen permiso
            if (aux.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), uni))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}