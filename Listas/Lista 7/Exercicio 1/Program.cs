using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o numero:");
        int numero = int.Parse(Console.ReadLine());
        
        bool resultado = VerificarPar(numero);
        Console.WriteLine($"O número {numero} é par? {resultado}");
    }

    static bool VerificarPar(int num)
    {
        return num % 2 == 0;
    }
}