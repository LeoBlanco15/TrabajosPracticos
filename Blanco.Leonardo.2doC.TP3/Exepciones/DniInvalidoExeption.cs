using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class DniInvalidoExeption : Exception
    {
        public DniInvalidoExeption() :base("Mensaje de DNI invalido por defecto")
        {

        }
        public DniInvalidoExeption(string mensaje) :base(mensaje)
        {

        }
        public DniInvalidoExeption(string mensaje, Exception e): base(mensaje, e) { }
        public DniInvalidoExeption(Exception e) :base("Mensaje de DNI invalido con exepcion", e) { }
    }
}
