using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraNS;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero aux = new Numero();
            double auxNumero = 657;
            string binario = "1010010001";

            Console.WriteLine(aux.DecimalBinario(auxNumero));
            Console.WriteLine(aux.BinarioDecimal(binario));
            Console.ReadKey();
        }
    }
}
