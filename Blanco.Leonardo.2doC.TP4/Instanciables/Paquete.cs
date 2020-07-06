using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }

        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado InformaEstado;
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public string DireccionEntrega 
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }
        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }
        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }
        /// <summary>
        /// Unico constructor de la clase
        /// </summary>
        /// <param name="direccionEntrega"></param>
        /// <param name="trackingID"></param>
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.TrackingID = trackingID;
            this.DireccionEntrega = direccionEntrega;
            this.Estado = EEstado.Ingresado;
        }

        /// <summary>
        /// Metodo que maneja el cambio de estado de los paquetes, invoca al estado de estos
        /// </summary>
        public void MockCicloDeVida()
        {
            while (!(this.Estado == EEstado.Entregado))
            {
                this.InformaEstado.Invoke(this, EventArgs.Empty);
                Thread.Sleep(4000);
                switch (this.Estado)
                {
                    case EEstado.Ingresado:
                        this.Estado = EEstado.EnViaje;
                        break;
                    case EEstado.EnViaje:
                        this.Estado = EEstado.Entregado;
                        PaqueteDAO.Insertar(this);
                        break;
                }
                
            }
            this.InformaEstado.Invoke(this, EventArgs.Empty);
        }
        /// <summary>
        /// muestran el ID y la direccion del paquete
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return string.Format("{0} para {1}", this.TrackingID, this.DireccionEntrega);
        }
        /// <summary>
        /// operador que devuelve si los IDs son iguales
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Paquete a, Paquete b)
        {
            return a.TrackingID == b.TrackingID;
        }
        /// <summary>
        /// operador que devuelve si los IDs son diferentes
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator != (Paquete a, Paquete b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tracking ID: {0} \nDireccion de entrega: {1} \nEstado del pedido: {2}", this.TrackingID, this.DireccionEntrega, this.Estado);

            return sb.ToString();
        }
    }
}
