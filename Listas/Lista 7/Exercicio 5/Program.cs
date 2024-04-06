using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[4, 4];

        PreencherMatriz(matriz);

        bool temBalista = VerificarBalista(matriz);

        if (temBalista)
        {
            Console.WriteLine("Fique atento! Existem balistas no tabuleiro.");
        }
        else
        {
            Console.WriteLine("Não há balistas no tabuleiro.");
        }
    }

    static void PreencherMatriz(int[,] matriz)
    {
        Console.WriteLine("Preencha a matriz 4x4 com números de 0 a 9:");

        for (int contador = 0; contador < 4; contador++)
        {
            for (int contadorDois = 0; contadorDois < 4; contadorDois++)
            {
                int numero;
                do
                {
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero < 0 || numero > 9)
                    {
                        Console.WriteLine("Insira um número válido (de 0 a 9).");
                    }
                } while (numero < 0 || numero > 9);

                matriz[contador, contadorDois] = numero;
            }
        }
    }

    static bool VerificarBalista(int[,] matriz)
    {
        bool temBalista = false;

        foreach (int elemento in matriz)
        {
            if (elemento == 0)
            {
                temBalista = true;
                break;
            }
        }

        return temBalista;
    }
}
