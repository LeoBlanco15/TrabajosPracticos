using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }
        /// <summary>
        /// inicializa todas las listas de correo
        /// </summary>
        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.Paquetes = new List<Paquete>();
        }
        /// <summary>
        /// muestra los datos de todo el correo
        /// </summary>
        /// <param name="elemetos"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elemetos)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Paquete item in this.Paquetes)
            {
                sb.AppendLine(string.Format("{0} {1} ({2})", item.TrackingID, item.DireccionEntrega, item.Estado));
            }

            return sb.ToString();
        }
        /// <summary>
        /// termina todos los hilos que estan andando
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread item in this.mockPaquetes)
            {
                item.Abort();
            }
        }
        /// <summary>
        /// operador que verifica que el paquete ya no se encuentre en la lista del correo
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Correo operator  +(Correo e, Paquete p)
        {
            Thread aux;

            foreach (Paquete item in e.Paquetes)
            {
                if (item == p)
                {
                    throw  new TrackingIdRepetidoExeption("El paquete ya esta en la lista");
                }
            }
            e.Paquetes.Add(p);
            aux = new Thread(p.MockCicloDeVida);
            e.mockPaquetes.Add(aux);
            aux.Start();

            return e;
        }
    }
}
