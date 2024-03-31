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

        Console.Write("Digite o nome a ser buscado: ");
        string nomeBuscado = Console.ReadLine();

        bool encontrado = false;
        foreach (string nome in nomes)
        {
            if (nome == nomeBuscado)
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
        {
            Console.WriteLine("ACHEI");
        }
        else
        {
            Console.WriteLine("NAO ACHEI");
        }
    }
}