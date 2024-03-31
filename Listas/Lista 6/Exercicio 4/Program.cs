using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[3, 3];

        Console.WriteLine("Digite 9 números inteiros para preencher a matriz 3x3:");
        for (int contador = 0; contador < 3; contador++)
        {
            for (int contadorDois = 0; contadorDois < 3; contadorDois++)
            {
                int numero = Convert.ToInt32(Console.ReadLine());

                if (contador + contadorDois == 2)
                {
                    matriz[contador, contadorDois] = numero * 2;
                }
                else
                {
                    matriz[contador, contadorDois] = numero;
                }
            }
        }

        Console.WriteLine("Resultado: ");
        for (int contador = 0; contador < 3; contador++)
        {
            for (int contadorDois = 0; contadorDois < 3; contadorDois++)
            {
                Console.Write($"{matriz[contador, contadorDois]} ");
            }
            Console.WriteLine();
        }
    }
}