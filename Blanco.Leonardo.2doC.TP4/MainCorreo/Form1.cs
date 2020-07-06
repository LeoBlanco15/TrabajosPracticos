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
        }

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
                        this.lstEstadoIngresado.Items.Add(item.MostrarDatos((IMostrar<Paquete>)item));
                        break;
                    case Paquete.EEstado.EnViaje:
                        this.lstEstadoEnViaje.Items.Add(item.MostrarDatos((IMostrar<Paquete>)item));
                        break;
                    case Paquete.EEstado.Entregado:
                        this.lstEstadoEntregado.Items.Add(item.MostrarDatos((IMostrar<Paquete>)item));
                        break;
                }
            }
        }
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            this.rtbMostrar.Text = elemento.MostrarDatos(elemento) + "\n";
            try
            {
                GuardaString.Guardar(elemento.MostrarDatos(elemento), (Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\salida.txt"));
            }
            catch (ArchivoExeption arch)
            {

                MessageBox.Show(arch.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }

        private void MainCorreo_FormClosing(object sender, FormClosingEventArgs e)
        {
            correo.FinEntregas();
        }
    }
}
