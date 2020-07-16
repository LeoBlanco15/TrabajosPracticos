using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivoExeption : Exception
    {
        public ArchivoExeption(string mensaje) : base(mensaje) { }
        public ArchivoExeption(string mensaje, Exception inner) : base(mensaje, inner) { }
    }
}
