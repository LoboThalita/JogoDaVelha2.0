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
        public Jogador1(Tabuleiro tabuleiro)
        {
            this.tabuleiro = tabuleiro;
        }
        public void Jogar()
        {
            //Correção de um bug q eu n sei o pq

            //Console.WriteLine("Informe a linha:");
            //int linha = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Informe a coluna:");
            //int coluna = Convert.ToInt32(Console.ReadLine())

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
