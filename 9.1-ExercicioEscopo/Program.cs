using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("O IR é de 7.5% e pode deduzir 142,00");
        }

        if (salario >= 2800.01 && salario <= 3751.0)
        {
            Console.WriteLine("O IR é de 15% e pode deduzir 350,00");
        }

        if (salario >= 3751.01 && salario <= 4664.0) {
            Console.WriteLine("IR de 222.5% e pode deduzir 636,00");
        }
    }
}