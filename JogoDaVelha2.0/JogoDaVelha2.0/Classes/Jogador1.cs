using JogoDaVelha2._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha2._0.Classes
{
    public class Jogador1 : IJogador
    {
        private Tabuleiro tabuleiro;
        public char peca { get; set; } = 'X';
        public string nome { get; set; }

        public Jogador1(Tabuleiro tabuleiro)
        {
            this.tabuleiro = tabuleiro;
        }
        public void Jogar()
        {
            Console.WriteLine("Informe a linha:");
            int linha;
            while (!int.TryParse(Console.ReadLine(), out linha))
            { 
            }
            Console.WriteLine("Informe a coluna:");
            int coluna;
            while (!int.TryParse(Console.ReadLine(), out coluna))
            {
            }

            tabuleiro.ColocarPeca(linha, coluna, peca);
        }
    }
}
