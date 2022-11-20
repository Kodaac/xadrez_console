using Tabuleiro;
using xadrez;
using System;

namespace xadrez_console // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TabuleiroXadrez tab = new TabuleiroXadrez(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0,0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1,3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2,4));

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
            

        }
    }
}