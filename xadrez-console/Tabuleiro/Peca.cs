using System;
using System.Collections.Generic;
using System.Drawing;

namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Color Cor { get; protected set; }
        public int QteMovimento { get; protected set; }
        public TabuleiroXadrez Tab { get; protected set; }

        public Peca(Posicao posicao, Color cor, TabuleiroXadrez tab)
        {
            Posicao = posicao;
            Cor = cor;
            QteMovimento = 0;
            Tab = tab;
        }
    }
}
