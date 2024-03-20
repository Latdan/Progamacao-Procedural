using System;

class Program
{
    static void Main(string[] args)
    {
        int contadorCresce = 0;
        int contadorDesce = 200;

        Console.WriteLine("Contagem crescente e Contagem decrescente:");
        while (contadorCresce <= 100 && contadorDesce >= 0)
        {
            Console.WriteLine($"{contadorCresce} - {contadorDesce}");
            contadorCresce += 2;
            contadorDesce -= 4;
        }
    }
}