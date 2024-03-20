using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a altura do retângulo:");
        int altura = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a base do retângulo:");
        int largura = int.Parse(Console.ReadLine());
        string texto = "";

        for (int contador = 0; contador < altura; contador++)
        {
            string linha = "";

            for (int contadorDois = 0; contadorDois < largura; contadorDois++)
            {
               linha += "*";
            }
            Console.WriteLine(linha);
        }
    }
}