using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Digite seu nome de usuario");

    string nomeUsuario = Console.ReadLine();

    Console.WriteLine("Digite sua senha");

    string suaSenha = Console.ReadLine();

    if (nomeUsuario == "admin")
    {

      if (suaSenha == "123senha")
      {

        Console.WriteLine("Login realizado com sucesso!");

      }

    }
    else
    {
      Console.WriteLine("Credenciais inválidas...");
    }
  }
}