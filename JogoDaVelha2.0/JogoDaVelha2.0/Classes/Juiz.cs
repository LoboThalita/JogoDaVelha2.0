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
        private int? vencedor;
        public string nomeJog1 { get; set; }
        public string nomeJog2 { get; set; }
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
            vencedor = null;
        }

        public void Iniciar()
        {
            Console.WriteLine("BEM-VINDO AO JOGO DA VELHA!!\n");
            Console.WriteLine("Informe o nome do Jogador 1 (X)");
            this.nomeJog1 = Console.ReadLine();
            Console.WriteLine("Informe o nome do Jogador 2 (O)");
            this.nomeJog2 = Console.ReadLine();

            Console.WriteLine($"Bem-vindos {nomeJog1} e {nomeJog2}, aperte qualquer tecla para iniciar o jogo");
            Console.Read();
        }

        public void Verifica()
        {
            //chama os metodos privados de acordo com a lógica

        }

        private void Jogador1Venceu()
        {
            this.fimDoJogo = true;
        }
        private void Jogador2Venceu()
        {
            this.fimDoJogo = true;
        }
    }
}
