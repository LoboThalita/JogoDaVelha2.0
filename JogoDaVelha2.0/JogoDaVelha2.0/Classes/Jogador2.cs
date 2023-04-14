using JogoDaVelha2._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha2._0.Classes
{
    public class Jogador2 : IJogador
    {
        private Tabuleiro tabuleiro;
        public char peca { get; set; } = 'O';
        public Jogador2(Tabuleiro tabuleiro)
        {
            this.tabuleiro = tabuleiro;
        }
        public void Jogar()
        {
            Console.WriteLine("Informe a linha:");
            int linha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a coluna:");
            int coluna = Convert.ToInt32(Console.ReadLine());

            tabuleiro.ColocarPeca(linha, coluna, peca);
        }

    }
}
