using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[3 , 3];

        Console.WriteLine("Digite 9 números inteiros para preencher a matriz 3x3:");
        for (int contador = 0; contador < 3; contador++)
        {
            for (int contadorDois = 0; contadorDois < 3; contadorDois++)
            {
                matriz[contador, contadorDois] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int somaDiagonalPrincipal = 0;
        for (int contador = 0; contador < 3; contador++)
        {
            somaDiagonalPrincipal += matriz[contador, contador];
        }
        Console.WriteLine(somaDiagonalPrincipal);
    }
}