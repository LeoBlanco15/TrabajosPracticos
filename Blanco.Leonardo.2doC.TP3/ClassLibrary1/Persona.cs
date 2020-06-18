using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using Exepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;
        //--------------------------------------------------------------------------------------------
        #region Propiedades
        /// <summary>
        /// Apellido de la persona con validacion en el set
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }
        /// <summary>
        /// set de nacionalidad
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }
        /// <summary>
        /// DNI de la persona con validacion de DNI y nacionalidad en el set
        /// </summary>
        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                try
                {
                    this.dni = this.ValidarDNI(this.Nacionalidad, value);
                }
                catch (DniInvalidoExeption e)
                {
                    throw e;
                }
                catch(NacionalidadInvalidaException e)
                {
                    throw e;
                }
            }
        }
        
        /// <summary>
        /// Nombre de la persona con validacion en el set
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre ;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }
        /// <summary>
        /// Conversor de string a int del DNI
        /// </summary>
        public string StringToDNI
        {
            set
            {
                try
                {
                    this.DNI = this.ValidarDNI(this.Nacionalidad, value);
                }
                catch (DniInvalidoExeption e)
                {
                    throw e;
                }
            }
        }
        #endregion
        //--------------------------------------------------------------------------------------------
        #region Constructores
        /// <summary>
        /// Constuctor por defecto, agrega todos los campos como blanco, nacionalidad como Argentina y DNI como 1
        /// </summary>
        public Persona()
        {
            this.Apellido = "";
            this.Nombre = "";
            this.Nacionalidad = ENacionalidad.Argentino;
            this.DNI = 1;
        }
        /// <summary>
        /// Constructor sin con parametros menos DNI, reusa el constructor por defecto
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this()
        {
            this.Nacionalidad = nacionalidad;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        /// <summary>
        /// Constructor con todos los parametros, reusa el parametro public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="dni"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad, int dni): this(nombre,  apellido, nacionalidad)
        {
            this.DNI = dni;
        }
        /// <summary>
        /// Constructor con todos los parametros y DNI pasado como string
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="dni"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad, string dni) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion
        //--------------------------------------------------------------------------------------------
        #region Metodos
        /// <summary>
        /// Overrite del metodo ToString. Metodo para hacer publicos los atributos de la persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1} \nDNI: {2} \nNacionalidad: {3}", this.Nombre, this.Apellido, this.DNI, this.Nacionalidad);
            return sb.ToString();
        }
        /// <summary>
        /// Validacion del DNI
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        private int ValidarDNI(ENacionalidad nacionalidad, int dni)
        {
            if ((dni >= 1 && dni <= 89999999) && nacionalidad == ENacionalidad.Argentino)
            {
                return dni;
            }
            else if ((dni >= 90000000 && dni <= 99999999) && nacionalidad == ENacionalidad.Extranjero)
            {
                return dni;
            }
            else
            {
                throw new NacionalidadInvalidaException();
            }
        }
        /// <summary>
        /// Validacion de DNI con el DNI como string de parametro
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        private int ValidarDNI(ENacionalidad nacionalidad, string dni)
        {
            int aux;
            if (int.TryParse(dni, out aux) && aux.ToString().Length <= 8)
            {
                try
                {
                    return this.ValidarDNI(nacionalidad, aux);
                }
                catch (NacionalidadInvalidaException e)
                {
                    throw e;
                }
            }
            else
            {
                throw new DniInvalidoExeption();
            }
        }
        /// <summary>
        /// Validacion de que nombre y apellido tengan todos sus caracteres correctos
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            
            if (Regex.IsMatch(dato, "^[A-Z][a-zA-Z]*$"))
            {
                return dato;
            }
            else
            {
                return "";
            }
        }
        #endregion
    }
}