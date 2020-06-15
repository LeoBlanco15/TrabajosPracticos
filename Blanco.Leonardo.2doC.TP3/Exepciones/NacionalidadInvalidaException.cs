using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        public NacionalidadInvalidaException() :base("Nacionalidad no encaja con DNI") { }
        public NacionalidadInvalidaException(string mensaje) : base(mensaje) { }
    }
}
