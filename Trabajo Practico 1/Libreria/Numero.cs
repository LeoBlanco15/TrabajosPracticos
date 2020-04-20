using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Numero
    {
        private double numero;

        private string SetNumero
        {
            set
            {
                    
            }
        }
        public Numero()
        {
            this.numero = 0;
        }
        private double ValidarNumero(string strNumero)
        {
            double aux;

            if(double.TryParse(strNumero, out aux))
            {
                return aux;
            }
            else
            {
                return 0;
            }
        }
    }
}
