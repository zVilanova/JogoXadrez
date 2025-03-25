using tabuleiro;
using tabuleiro.exceptions;
using xadrez;

namespace Projeto_Xadrez
{
    class Program
    {
        public static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosicao());
        }
    }
}