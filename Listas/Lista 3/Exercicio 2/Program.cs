using System;

class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Digite quantos itens você comprou");

        int totalItens = int.Parse(Console.ReadLine());

        int contador = 0;

        double totalValor = 0.0;

        while (contador < totalItens)
        {

            Console.WriteLine("Digite o valor do " + (contador+1) + "° item comprado:");

            totalValor += double.Parse(Console.ReadLine());

            contador++;

        }

        if (totalValor < 150)
        {

            Console.WriteLine("A compra nao possui frete gratis.");

        }

        else
        {

            Console.WriteLine("Parabens! Voce ganhou frete gratis em sua compra de valor R$" + totalValor + "!");

        }

    }




}