using System;

class Program
{
    static void Main(string[] args)
    {
        int altura;

        while (true)
        {
            Console.WriteLine("Digite a altura do triângulo (entre 1 e 9):");
            string alturaValida = Console.ReadLine();

            if (int.TryParse(alturaValida, out altura) && altura >= 1 && altura <= 9)
            {
                ImprimirTriangulo(altura);
                break;
            }
            else
            {
                Console.WriteLine("Altura inválida, insira uma altura entre 1 e 9.");
            }
        }

    }

    static void ImprimirTriangulo(int altura)
    {
        for (int contador = 1; contador <= altura; contador++)
        {
            for (int contadorDois = 1; contadorDois <= contador; contadorDois++)
            {
                Console.Write(contadorDois + " ");
            }
            Console.WriteLine();
        }
    }
}