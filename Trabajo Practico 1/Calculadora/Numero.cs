using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNS
{
    public class Numero
    {
        private double numero;

        #region propiedades/constructores
        public string SetNumero
        {
            set
            {
                double aux = Numero.ValidadNumero(value);

                this.numero = aux;
            }
        }
        public Numero()
        {
            this.SetNumero = "0";
        }
        public Numero(double numero)
        {
            this.SetNumero = numero.ToString();
        }
        public Numero(string numero)
        {
            this.SetNumero = numero;
        }
        #endregion

        #region convercion/validacion
        public string BinarioDecimal(string binario)
        {
            if (!(binario.Contains("1") || binario.Contains("0")))
            {
                return binario;
            }
           double aux = Convert.ToInt32(binario, 2);
           if (aux == Math.Floor(aux))
           {
                return aux.ToString();
           }
           else
           {
                return "Valor invalido";
           }
            
        }
        public string DecimalBinario(double numero)
        { 

            return this.DecimalBinario(numero.ToString());
        }
        public string DecimalBinario(string numero)
        {
            double aux = Numero.ValidadNumero(numero);
            if(aux > 0 && aux == Math.Floor(aux))
            { 
                string valor = Convert.ToString((int)aux, 2);
                return valor;
            }
            else
            {
                return "Valor invalido";
            }
        }
        private static double ValidadNumero(string numero)
        {
            double aux;
            if (double.TryParse(numero, out aux))
            {
                return aux;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region sobrecarga de operaciones
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            if(n2.numero !=0)
            {
                return n1.numero / n2.numero;
            }
            else
            {
                return double.MinValue;
            }
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        #endregion
        
    }

}
