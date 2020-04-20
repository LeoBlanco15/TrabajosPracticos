using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNS
{
    public static class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            if (operador == "+" || operador == "-" || operador == "/" || operador == "*")
            {
                return operador;
            }
            else;
            {
                return "+";
            }
        }
        public static double Operar(Numero n1, Numero n2, string operador)
        {
            switch(Calculadora.ValidarOperador(operador))
            {
                case "+":
                    return n1 + n2;
                case "-":
                    return n1 - n2;
                case "*":
                    return n1 * n2;
                case "/":
                    return n1 / n2;
                default:
                    return 0;
            }
        }
    }
}
