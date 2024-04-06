using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a idade do nadador:");
        int idade = int.Parse(Console.ReadLine());
        string categoria = ClassificarNadador(idade);
        Console.WriteLine($"O nadador de {idade} anos está na categoria: {categoria}");
    }

    static string ClassificarNadador(int idade)
    {
        if (idade >= 5 && idade <= 7)
        {
            return "Infantil A";
        }
        else if (idade >= 8 && idade <= 10)
        {
            return "Infantil B";
        }
        else if (idade >= 11 && idade <= 13)
        {
            return "Juvenil A";
        }
        else if (idade >= 14 && idade <= 17)
        {
            return "Juvenil B";
        }
        else if (idade >= 18)
        {
            return "Adulto";
        }
        else
        {
            return "Idade fora da faixa de classificação";
        }
    }
}