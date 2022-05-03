using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido = valorInvestido + (contadorMes * 0.0036);
                Console.WriteLine("Mês " + contadorMes + " R$ " + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
