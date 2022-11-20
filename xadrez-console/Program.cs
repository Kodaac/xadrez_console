using Tabuleiro;
using xadrez;
using System;

namespace xadrez_console // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TabuleiroXadrez tab = new TabuleiroXadrez(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tab);

                Console.ReadLine();

            } catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}