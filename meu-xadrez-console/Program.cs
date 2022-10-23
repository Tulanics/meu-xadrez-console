using tabuleiro;
using xadrez;

namespace meu_xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            PosicaoXadrez pos1 = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            Console.WriteLine("---");

            Console.WriteLine(pos1);            
            Console.WriteLine(pos1.toPosicao());
        }
    }
}