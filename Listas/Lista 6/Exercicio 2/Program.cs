using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[10];

        Console.WriteLine("Digite 10 nomes:");
        for (int contador = 0; contador < 10; contador++)
        {
            Console.Write($"Nome {contador + 1}: ");
            nomes[contador] = Console.ReadLine();

        }

        Console.WriteLine("\n");
        for (int contador = nomes.Length - 1; contador >= 0; contador--)
        {
            if (contador % 2 == 0)
            {
                Console.WriteLine($"Nome {contador}: {nomes[contador]}");
            }
        }
    }
}