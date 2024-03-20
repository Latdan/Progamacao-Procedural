class Program
{

    static void Main(string[] args)
    {
    Tabuleiro.InicializaTabuleiro();

        for (int linha = 0; linha < 8; linha++)
        {
        
            for (int coluna = 0; coluna < 8; coluna++)
            {

                if (linha == 0 || linha == 2 || linha == 4 || linha == 6 || coluna == null)
                {
                    Tabuleiro.Adicionar(linha, coluna, "C");
                }

            }
        }
        Tabuleiro.ImprimeTabuleiro();
    }

}