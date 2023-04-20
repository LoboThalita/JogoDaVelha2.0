using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha2._0.Classes
{
    public class Jogador1 : Jogador
    {
        public Jogador1(Tabuleiro tabuleiro) : base(tabuleiro)
        {
            peca = 'X';
        }

    }
}
