using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        public enum ETipo { Monovolumen, Sedan }
        ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será Monovolumen
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Automovil(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color, ETipo.Monovolumen)
        {
        }
        /// <summary>
        /// constructor donde se puede declarar el tipo
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="eTipo"></param>
        public Automovil(EMarca marca, string chasis, ConsoleColor color, ETipo eTipo) : base(chasis, marca, color)
        {
            this.tipo = eTipo;
        }

        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AUTOMOVIL");
            sb.Append(base.Mostrar());
            sb.AppendFormat("\nTAMAÑO: {0}: {1}\n", this.Tamanio.ToString(), this.tipo.ToString());
            sb.AppendLine("---------------------\n");

            return sb.ToString();
        }
    }
}
