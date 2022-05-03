using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando variáveis de ponto flutuante");

            double salario;
            salario = 1200.70;

            Console.WriteLine(salario);

            double idade;
            idade = 15 / 2; // Numero inteiro dividido por outro, retorno = numero inteiro
            Console.WriteLine(idade);

            idade = 15.0 / 2; // Numero double dividido por outro, retorno = numero double
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3" + idade); // retorna idade truncada

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3", + idade); // retorna idade com casas decimais

            Console.WriteLine("A execução acabou. Tecle enter para sair...");

            Console.ReadLine();
        }
    }
}
