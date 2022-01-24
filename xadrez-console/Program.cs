using System;
using Tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);
            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
