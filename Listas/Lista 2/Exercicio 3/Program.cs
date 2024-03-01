using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual o nome?");

        string nomeDaCrianca = Console.ReadLine();

        if (nomeDaCrianca == "Filomena")
        {

            Console.WriteLine("Rotina da Filomena:\n"
            + "1. Escola das 07h as 12h\n"
            + "2. Almoço das 12h as 13h\n"
            + "3. Futebol das 14h as 16h\n"
            + "4. Dever de casa das 16h as 18h");

        }

        else if (nomeDaCrianca == "Joselito")
        {

            Console.WriteLine("Rotina do Joselito:\n"
            + "1. Escola das 07h as 12:30\n"
            + "2. Almoço das 13h as 14h\n"
            + "3. Natação das 14h as 16h\n"
            + "4. Reforço escolar das 16h as 19h");

        }
    }
}