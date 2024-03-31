using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[4, 4];

        Console.WriteLine("Digite 16 números inteiros para preencher a matriz 4x4:");
        for (int contador = 0; contador < 4; contador++)
        {
            for (int contadorDois = 0; contadorDois < 4; contadorDois++)
            {
                matriz[contador, contadorDois] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nEscolha uma opção:");
        Console.WriteLine("1 - Imprimir todos os elementos da matriz");
        Console.WriteLine("2 - Somar todos os elementos e exibir o resultado");
        Console.WriteLine("3 - Somar todos os elementos da terceira linha e exibir o resultado");
        Console.WriteLine("4 - Somar os elementos da diagonal principal");
        Console.WriteLine("5 - Somar todos os elementos de índice par da segunda linha");
        Console.Write("Opção: ");
        int opcao = Convert.ToInt32(Console.ReadLine());

        if (opcao == 1)
        {
            ImprimirMatriz(matriz);
        }
        else if (opcao == 2)
        {
            SomarTodosElementos(matriz);
        }
        else if (opcao == 3)
        {
            SomarTerceiraLinha(matriz);
        }
        else if (opcao == 4)
        {
            SomarDiagonalPrincipal(matriz);
        }
        else if (opcao == 5)
        {
            SomarElementosIndiceParSegundaLinha(matriz);
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        Console.WriteLine("\nMatriz:");
        for (int contador = 0; contador < 4; contador++)
        {
            for (int contadorDois = 0; contadorDois < 4; contadorDois++)
            {
                Console.Write($"{matriz[contador, contadorDois]} ");
            }
            Console.WriteLine();
        }
    }

    static void SomarTodosElementos(int[,] matriz)
    {
        int soma = 0;
        foreach (int elemento in matriz)
        {
            soma += elemento;
        }
        Console.WriteLine($"\nA soma de todos os elementos da matriz é: {soma}");
    }

    static void SomarTerceiraLinha(int[,] matriz)
    {
        int soma = 0;
        for (int contadorDois = 0; contadorDois < 4; contadorDois++)
        {
            soma += matriz[2, contadorDois];
        }
        Console.WriteLine($"\nA soma dos elementos da terceira linha é: {soma}");
    }

    static void SomarDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;
        for (int contador = 0; contador < 4; contador++)
        {
            soma += matriz[contador, contador];
        }
        Console.WriteLine($"\nA soma dos elementos da diagonal principal é: {soma}");
    }

    static void SomarElementosIndiceParSegundaLinha(int[,] matriz)
    {
        int soma = 0;
        for (int contadorDois = 0; contadorDois < 4; contadorDois++)
        {
            if (contadorDois % 2 == 0)
            {
                soma += matriz[1, contadorDois];
            }
        }
        Console.WriteLine($"\nA soma dos elementos de índice par da segunda linha é: {soma}");
    }
}