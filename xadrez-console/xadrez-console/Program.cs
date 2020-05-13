using System;
using tabuleiro;
using xadrez;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);

                    Console.Write("origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("origem: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    Console.WriteLine("");
                    partida.executaMovimento(origem, destino);
                }
                


            
            }catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            
        }
    }
}
