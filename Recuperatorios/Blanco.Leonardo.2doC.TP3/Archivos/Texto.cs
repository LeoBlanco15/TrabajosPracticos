using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Exepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Guarda un sting en un archivo de texto
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(archivo))
                {
                    try
                    {
                        writer.Write(datos);
                    }
                    catch (Exception)
                    {
                        throw new ArchivosException();
                    }
                }
            }
            catch (Exception)
            {
                throw new ArchivosException();
            }
            if (File.Exists(archivo))
            {
                return true;
            }
            else
            {
                throw new ArchivosException();
            }
        }
        /// <summary>
        /// Lee de un archivo y lo pone en un string
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    try
                    {
                        datos = reader.ReadToEnd();
                    }
                    catch (Exception)
                    {
                        throw new ArchivosException();
                    }
                }
            }
            catch (Exception)
            {
                throw new ArchivosException();
            }
            if (File.Exists(archivo))
            {
                return true;
            }
            else
            {
                throw new ArchivosException();
            }
        }
    }
}
