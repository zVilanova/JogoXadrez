using tabuleiro;

namespace xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) //repassa o tab e a cor para a superclasse (Peca)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
