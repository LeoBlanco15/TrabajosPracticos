using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculadoraNS;

namespace CalculadoraForm
{
    public partial class Main : Form
    {
        private Numero numero1 = new Numero();
        private Numero numero2 = new Numero();
        private bool cambio = false;
        public Main()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double aux;

            numero1.SetNumero =  txtNumero1.Text;
            numero2.SetNumero = txtNumero2.Text;
            cambio = false;
            aux = Calculadora.Operar(numero1, numero2, cmbOperador.Text);

            lblResultado.Text = aux.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.SelectedIndex = 0;
            lblResultado.Text = "Resultado";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (cambio == false)
            {
                lblResultado.Text = numero1.DecimalBinario(lblResultado.Text);
                cambio = true;
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (cambio == true)
            {
                lblResultado.Text = numero1.BinarioDecimal(lblResultado.Text);
                cambio = false;
            }
        }
    }
}
