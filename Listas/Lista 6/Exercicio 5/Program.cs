using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[10];
        int contador = 0;

        Console.WriteLine("Digite números para preencher o vetor:");
        while (contador < 10)
        {
            Console.Write($"Número {contador + 1}: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 10 && numero <= 50)
            {
                vetor[contador] = numero;
                contador++;
            }
            else
            {
                Console.WriteLine("Número inválido. Por favor, digite um número entre 10 e 50.");
            }
        }

        Console.WriteLine("Números armazenados no vetor: ");
        foreach (int numero in vetor)
        {
            Console.WriteLine(numero);
        }
    }
}