using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        int primeiroNumero = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int segundoNumero = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número:");
        int terceiroNumero = int.Parse(Console.ReadLine());

        int maior = EncontrarMaior(primeiroNumero, segundoNumero, terceiroNumero);
        Console.WriteLine($"O maior número é: {maior}");
    }

    static int EncontrarMaior(int primeiroNumero, int segundoNumero, int terceiroNumero)
    {
        return Math.Max(primeiroNumero, Math.Max(segundoNumero, terceiroNumero));
    }
}