using Tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro.Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (tabuleiro.Peca(i, j) == null) System.Console.Write("- ");
                    else System.Console.Write(tabuleiro.Peca(i, j) + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
