Console.WriteLine("Insira a base");
double baseTriangulo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insira a altura");
double altura = Convert.ToDouble(Console.ReadLine());

double area = (baseTriangulo * altura) / 2.0;

bool isTrue = false;

if (area > 20)
{isTrue = true;}
Console.WriteLine("A área do triângulo é maior que 20? " + isTrue);


