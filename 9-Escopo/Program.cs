using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas >= 2;
            string mensagemAdicional;

            if (acompanhado)
            {
                mensagemAdicional = "João estã acompanhado!";  
            }
            else
            {
                mensagemAdicional = "João não está acompanhado";
            }
           // bool acompanhado = true;

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("João pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João não pode entrar.");
            }

            Console.ReadLine();
        }
    }
}
