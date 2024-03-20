using System;

class Program
{

    static void Main(string[] args)
    {
        bool numeroNegativo = false;
        int somaTotal = 0;

        while (!numeroNegativo)
        {
            Console.WriteLine("digite os números ímpares:");
            int numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado < 0)
            {
                numeroNegativo = true;
            }
            else if (numeroDigitado % 2 != 0)
                somaTotal += numeroDigitado;
        }
        Console.WriteLine("A soma dos impares é: " + somaTotal);
    }
}