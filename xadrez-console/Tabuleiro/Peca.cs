
namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimento { get; protected set; }
        public TabuleiroXadrez Tab { get; protected set; }

        public Peca(TabuleiroXadrez tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QteMovimento = 0;
           
        }


    }
}
