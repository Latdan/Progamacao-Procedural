using System;
using System.Net.Http.Headers;

class Program
{

    static void Main(string[] args)
    {
        double salarioTotal = 0.0;

        double salarioMaior = 0.0;

        int totalFilhos = 0;

        for (int contador = 20; contador > 0; contador--)
        {

            Console.WriteLine("Digite seu salário");

            double salario = double.Parse(Console.ReadLine());

            salarioTotal += salario;

            Console.WriteLine("Quantos filhos você tem?");

            int filhos = int.Parse(Console.ReadLine());

            totalFilhos += filhos;

            if (salario > salarioMaior)
            {

                salarioMaior = salario;

            }

        }

        double mediaSalarial = salarioTotal / 20;

        int mediaFilhos = totalFilhos / 20;


        Console.WriteLine("Media salarial = R$" + mediaSalarial);
        Console.WriteLine("Media de filhos =" + mediaFilhos);
        Console.WriteLine("O maior salário da cidade eh: R$" + salarioMaior);


    }

}