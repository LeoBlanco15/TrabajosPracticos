using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrackingIdRepetidoExeption : Exception
    {
        public TrackingIdRepetidoExeption(string mensaje) : base(mensaje) { }
        public TrackingIdRepetidoExeption(string mensaje, Exception inner) :base(mensaje, inner) { }
    }
}
