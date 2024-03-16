using System;

class Program
{
    static void Main(string[] args)
    {
        for (int contador = 1; contador <= 10; contador++)
        {
            Console.WriteLine("Tabuada do " + contador + ":");
            for (int contadorDois = 1; contadorDois <= 10; contadorDois++)
            {
                Console.WriteLine(contador + " x " + contadorDois + " = " + contador * contadorDois);
            }
            Console.WriteLine();
        }

    }
}