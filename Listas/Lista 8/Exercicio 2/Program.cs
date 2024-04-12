using System;

struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool disponivelEmEstoque;
}

class Program
{
    static void Main(string[] args)
    {
        Produto[] produtos = new Produto[4];

        for (int contador = 0; contador < produtos.Length; contador++)
        {
            Console.WriteLine($"Digite os dados do produto {contador + 1}:");
            
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("Preço: ");
            double preco = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Disponível em estoque (true/false): ");
            bool disponivelEmEstoque = Convert.ToBoolean(Console.ReadLine());
            
            produtos[contador] = new Produto { id = id, nome = nome, preco = preco, disponivelEmEstoque = disponivelEmEstoque };
        }

        Console.WriteLine("Produtos disponíveis em estoque:");
        for (int contador = 0; contador < produtos.Length; contador++)
        {
            if (produtos[contador].disponivelEmEstoque)
            {
                Console.WriteLine($"Nome: {produtos[contador].nome}");
            
                Console.WriteLine($"Preço: R${produtos[contador].preco}");
            }
        }
    }
}
