using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MainCorreo
{
    public partial class MainCorreo : Form
    {
        private Correo correo;

        public MainCorreo()
        {
            InitializeComponent();
            correo = new Correo();
            try
            {
                PaqueteDAO.EventoDatos += MostrarError;
            }
            catch(TypeInitializationException)
            {
                MessageBox.Show("Hubo un error ingresando la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Agrega a la lista de paquetes uno nuevo, agrega al evento paq_InformaEstado
        /// e inicia el thread del paquete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Paquete aux = new Paquete(this.txtDireccion.Text, this.mtxtTrackingID.Text);
                aux.InformaEstado += paq_InformaEstado;
                correo += aux;
            }
            catch (TrackingIdRepetidoExeption exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// invoca al thread y llama ActualizarEstados
        /// para cambiar en la pantalla de lista el paquete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {

                this.ActualizarEstados();
            }
        }
        /// <summary>
        /// cambia de lista el paquete segun en que estado este
        /// </summary>
        private void ActualizarEstados()
        {
            this.lstEstadoIngresado.Items.Clear();
            this.lstEstadoEnViaje.Items.Clear();
            this.lstEstadoEntregado.Items.Clear();

            foreach (Paquete item in this.correo.Paquetes)
            {
                switch (item.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        this.lstEstadoIngresado.Items.Add(item);
                        break;
                    case Paquete.EEstado.EnViaje:
                        this.lstEstadoEnViaje.Items.Add(item);
                        break;
                    case Paquete.EEstado.Entregado:
                        this.lstEstadoEntregado.Items.Add(item);
                        break;
                }
            }
        }
        /// <summary>
        /// Muestra la informacion del elemento pasado como parametro
        /// y los guarda en un archivo de texto
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            try
            {
                this.rtbMostrar.Text = elemento.MostrarDatos(elemento) + "\n";
                GuardaString.Guardar(elemento.MostrarDatos(elemento), (Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\salida.txt"));
            }
            catch (ArchivoExeption arch)
            {

                MessageBox.Show(arch.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("ningun objeto seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// muestra todos los paquetes con sus estados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }
        /// <summary>
        /// Muesta el item seleccionado por pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
        /// <summary>
        /// finaliza todos los threads de correo cuando se cierra el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainCorreo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.correo.FinEntregas();
        }
        /// <summary>
        /// Metodo usado para mostrar los errores de base de datos
        /// </summary>
        /// <param name="mensaje"></param>
        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
