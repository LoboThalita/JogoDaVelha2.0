using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha2._0.Classes
{
    public class Juiz
    {
        private Tabuleiro tabuleiro;
        private Jogador1 jogador1;
        private Jogador2 jogador2;
        private bool vezJogador1;
        public bool fimDoJogo { get; set; }
        public bool VezJogador1
        {
            get
            {
                vezJogador1 = !vezJogador1;
                return vezJogador1;
            }
        }
        public Juiz(Tabuleiro tabuleiro, Jogador1 jogador1, Jogador2 jogador2)
        {
            this.tabuleiro = tabuleiro;
            this.jogador1 = jogador1;
            this.jogador2 = jogador2;
            vezJogador1 = false;
            fimDoJogo = false;
        }

        public void Iniciar()
        {
            Console.WriteLine("BEM-VINDO AO JOGO DA VELHA!!\n");
            Console.WriteLine("Informe o nome do Jogador 1 (X)");
            jogador1.nome = Console.ReadLine();
            Console.WriteLine("Informe o nome do Jogador 2 (O)");
            jogador2.nome = Console.ReadLine();

            Console.WriteLine($"Bem-vindos {jogador1.nome} e {jogador2.nome}, aperte qualquer tecla para iniciar o jogo");
            Console.Read();
        }

        public void Verifica()
        {
            tabuleiro.Exibir();
            for (int i = 0; i < 3; i++)
            {
                if (ChecaColuna(i))
                {
                    JogadorXVenceu(tabuleiro.peca[0,i]);
                    break;
                }else if (ChecaLinha(i))
                {
                    JogadorXVenceu(tabuleiro.peca[i,0]);
                    break;
                }else if (ChecaDiagonalPrincipal())
                {
                    JogadorXVenceu(tabuleiro.peca[i, i]);
                    break;
                }else if (ChecaDiagonalSecundária())
                {
                    JogadorXVenceu(tabuleiro.peca[2,0]);
                    break;
                }else if (ChecaEmpate())
                {
                    Empate();
                    break;
                }
            }
            
        }
        private void Finalizar(string? vencedor)
        {
            if(vencedor != null)
                Console.WriteLine($"{vencedor} Venceu!!! Parabéns!");
            else
                Console.WriteLine("Empate!");

            Console.WriteLine("\nObrigado por jogar! Volte sempre");

            this.fimDoJogo = true;
        }
        private void JogadorXVenceu(char jogador)
        {
            if (jogador == 'X')
            {
                Finalizar(jogador1.nome);
            }
            else
            {
                Finalizar(jogador2.nome);
            }
        }
        private void Empate()
        {
            Finalizar(null);
        }
        private bool ChecaLinha(int i)
        {
            return tabuleiro.peca[i, 0] == tabuleiro.peca[i, 1] && tabuleiro.peca[i, 1] == tabuleiro.peca[i, 2] && tabuleiro.peca[i, 0] != ' ';
        }
        private bool ChecaColuna(int i)
        {
            return tabuleiro.peca[0, i] == tabuleiro.peca[1, i] && tabuleiro.peca[1, i] == tabuleiro.peca[2, i] && tabuleiro.peca[0, i] != ' ';
        }
        private bool ChecaDiagonalPrincipal()
        {
            return tabuleiro.peca[0, 0] == tabuleiro.peca[1, 1] && tabuleiro.peca[1, 1] == tabuleiro.peca[2, 2] && tabuleiro.peca[0, 0] != ' ';
        }
        private bool ChecaDiagonalSecundária()
        {
            return tabuleiro.peca[2, 0] == tabuleiro.peca[1, 1] && tabuleiro.peca[1, 1] == tabuleiro.peca[0, 2] && tabuleiro.peca[2, 0] != ' ';
        }
        private bool ChecaEmpate()
        {
            int check = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tabuleiro.peca[i, j] != ' ') check++;
                }
            }
            if (check == 9) return true;
            else return false;
        }
    }
}
