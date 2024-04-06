using System;

class Program
{
    static void Main(string[] args)
    {
        int[] pesosVagoes = new int[12];

        PreencherVetor(pesosVagoes);

        VerificarExcessoPeso(pesosVagoes);
    }

    static void PreencherVetor(int[] vetor)
    {
        Console.WriteLine("Digite o peso de cada vagão:");

        for (int contador = 0; contador < vetor.Length; contador++)
        {
            Console.Write($"Peso do vagão {contador + 1}: ");
            vetor[contador] = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void VerificarExcessoPeso(int[] vetor)
    {
        for (int contador = 0; contador < vetor.Length; contador++)
        {
            if (vetor[contador] > 50)
            {
                Console.WriteLine($"O vagão {contador + 1} ultrapassou o limite de peso.");
            }
        }
    }
}