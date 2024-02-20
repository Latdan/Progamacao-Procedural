
Console.WriteLine("Digite sua primeira nota");
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua segunda nota");
double nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua terceira nota");
double nota3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua quarta nota");
double nota4 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2 + nota3 + nota4) / 4.0;

Console.WriteLine("A média do aluno é: " + media);
