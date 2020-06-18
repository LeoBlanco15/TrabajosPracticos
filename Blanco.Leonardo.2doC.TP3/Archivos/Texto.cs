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
            using (StreamWriter writer = new StreamWriter(archivo))
            {
                writer.Write(datos);
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
        public bool Leer(string archivo, out string datos)
        {
            using (StreamReader reader = new StreamReader(archivo))
            {
                datos = reader.ReadToEnd();
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
