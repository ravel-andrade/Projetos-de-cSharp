﻿using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor JogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            this.tab = new Tabuleiro(8,8);
            this.turno = 0;
            JogadorAtual = Cor.Branco;
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementaQteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
            
        }

        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('c',1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('c',2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('d',2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('e',2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('e',1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branco), new PosicaoXadrez('d',1).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('c', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('c', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('d', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('e', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('e', 8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preto), new PosicaoXadrez('d', 8).toPosicao());

        }
    }
}
