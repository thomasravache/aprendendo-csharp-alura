using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._3_FatorialOpcional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int numero = 1; numero <= 10; numero++)
            {
                int acc = numero;
                for (int fatorial = numero - 1; fatorial >= 1; fatorial--)
                {
                    acc *= fatorial;
                }
                Console.WriteLine("Fatorial de " + numero + " é " + acc);
            }

            Console.ReadLine();
        }
    }
}
