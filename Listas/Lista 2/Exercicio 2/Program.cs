using System;
using System.Net.Http.Headers;
class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Digite sua primeira nota");

        double Nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua segunda nota");

        double Nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua terceira nota");

        double Nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua quarta nota");

        double Nota4 = double.Parse(Console.ReadLine());

        double media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

        if (media >= 5.0)
        {

            Console.WriteLine("Aluno aprovado");

        }
        else if (media < 5.0 && media >= 3.0)
        {

            Console.WriteLine("Aluno em recuperacao");

        }

        else
        {

            Console.WriteLine("Aluno reprovado");

        }
    }

}