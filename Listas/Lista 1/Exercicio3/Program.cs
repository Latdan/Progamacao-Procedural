Console.WriteLine("Digite quantos centavos deseja converter em reais: ");
int centavos = int.Parse (Console.ReadLine());

int reais = centavos / 100;

int sobra = centavos % 100;

Console.WriteLine("O total em dinheiro é: " + reais + " reais e " + sobra  + " centavos ou também R$" + reais + "," + sobra);