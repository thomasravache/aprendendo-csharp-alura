using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.0;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; // forçar a conversão de tipos (casting)

            Console.WriteLine(salarioEmInteiro);

            // int ocupa 32 bits
            int idade = 13000000000; // dá erro pois não suporta um valor tão grande
            Console.WriteLine(idade);

            // long ocupa mais espaço na memória - 64 bits
            long idade2 = 13000000000; // não dá erro
            Console.WriteLine(idade2);

            // ocupa menos memoria, mas armazena um numero menor que int - ocupa 16 bits
            short quantidadeProdutos = 10;
            Console.WriteLine(quantidadeProdutos);

            // float suporta uma precisao de casas decimais menor que o double
            float altura = 1.8f; // precisa do sufixo f --> não é muito utiizado
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
