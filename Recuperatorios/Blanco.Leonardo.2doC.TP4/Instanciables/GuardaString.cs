using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        /// <summary>
        /// guarda en un archivo de texto el string de parametro
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public static bool Guardar(this string texto, string archivo)
        {
            File.AppendAllText(archivo, texto + "\n");
            //using (StreamWriter writer = new StreamWriter(archivo))
            //{
            //    //writer.WriteLine(texto);
            //    File.AppendAllText(archivo, texto + "\n");

            //}
            if (File.Exists(archivo))
            {
                return true;
            }
            else
            {
                throw new ArchivoExeption("El archivo de texto no existe");
            }
        }
    }
}
