using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JogoDaVelha2._0.Classes
{
    public class Tabuleiro
    {
        public int[,] matriz = new int[3, 3];
        public char[,] peca = new char[3, 3];
        public Tabuleiro()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (this.matriz[i, j] == 1) peca[i, j] = 'X';
                    else if (this.matriz[i, j] == 2) peca[i, j] = 'O';
                    else peca[i, j] = ' ';
                }
            }
        }
        public void Exibir()
        {
            Console.Clear();

            Console.WriteLine("   0   1   2");
            Console.WriteLine("0  {0} | {1} | {2} ", peca[0, 0], peca[0, 1], peca[0, 2]);
            Console.WriteLine("  ---+---+---");
            Console.WriteLine("1  {0} | {1} | {2} ", peca[1, 0], peca[1, 1], peca[1, 2]);
            Console.WriteLine("  ---+---+---");
            Console.WriteLine("2  {0} | {1} | {2} ", peca[2, 0], peca[2, 1], peca[2, 2]);
            Console.WriteLine();
        }

        public void ColocarPeca(int linha, int coluna, char p)
        {
            if (linha >= 0 && coluna >= 0 && linha < 3 && coluna < 3)
                if (peca[linha, coluna] == ' ')
                    peca[linha, coluna] = p;
                else
                {
                    Console.WriteLine("Posição ocupada, escolha outra!");
                    PosicaoInvalida(p);
                }

            else
            {
                Console.WriteLine("Posição inválida");
                PosicaoInvalida(p);
            }
                
        }

        private void PosicaoInvalida(char p)
        {
            Console.WriteLine("Informe a linha:");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a coluna:");
            int c = Convert.ToInt32(Console.ReadLine());
            ColocarPeca(l, c, p);
        }
    }
}
