using System;

class Program
{
    static void Main(string[] args)
    {
        for (int contador = 10; contador >= 1; contador--)
        {

            for (int contadorDois = 1; contadorDois <= 10; contadorDois++)
            {
                Console.WriteLine($"{contador} x {contadorDois} = {contador * contadorDois}");
            }

            Console.WriteLine();
        }
    }
}