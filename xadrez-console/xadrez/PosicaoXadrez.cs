using tabuleiro;

namespace xadrez
{
    /* Posicoes da matriz, com posicoes referente a um tabuleiro
     * de xadrez real */
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }
        //converte a posicao do xadrez, para um posicao interna de uma matriz
        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }
        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
