using System;
using System.Reflection;
using System.Security.Cryptography;

class Program
{

    static void Main(string[] args)
    {

        string usuarioLogin = "admin";

        string senhaLogin = "123senha";


        int contador = 0;

        while (contador < 3)
        {

            Console.WriteLine("Digite o usuário:");

            string usuarioDigitado = Console.ReadLine();

            Console.WriteLine("Digite sua senha:");

            string senhaDigitada = Console.ReadLine();

            if (usuarioDigitado == usuarioLogin && senhaDigitada == senhaLogin)
            {


                Console.WriteLine("Login realizado com sucesso!");

                break;

            }

            contador++;

        }

        if (contador >= 3)
        {

            Console.WriteLine("Sua conta foi bloqueada.");
        }



    }
}