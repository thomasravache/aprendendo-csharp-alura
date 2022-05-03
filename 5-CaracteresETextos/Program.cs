using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5");

            // character
            char primeiraLetra = 'A'; // Tem que ter aspas simples para que seja entendido como char!
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra); // caractere "=" --> Dec 61 da tabela ASCII

            primeiraLetra = (char)(primeiraLetra + 1); 
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia " + 2020; // texto
            Console.WriteLine(titulo);

            // texto com quebra de linha

            string teste = @"
- teste1
- teste2
- teste3
";
            Console.WriteLine(teste);

            Console.ReadLine();
        }
    }
}
