namespace JogoDaVelha2._0.Classes;

public class Juiz
{
    private readonly Tabuleiro tabuleiro;
    private readonly Jogador jogador1;
    private readonly Jogador jogador2;
    private bool vezJogador1;
    public bool FimDoJogo { get; set; }

    //Todas as vezes que esta propriedade é chamada ela muda de valor
    //Sendo assim, sempre depois que VezJogador1 = True é verificado, ele vira False, e vice versa.
    public bool VezJogador1
    {
        get
        {
            vezJogador1 = !vezJogador1;
            return vezJogador1;
        }
    }

    public Juiz(Tabuleiro tabuleiro, Jogador jogador1, Jogador jogador2)
    {
        this.tabuleiro = tabuleiro;
        this.jogador1 = jogador1;
        this.jogador2 = jogador2;
        vezJogador1 = false;
        FimDoJogo = false;
    }

    public void Iniciar()
    {
        Console.WriteLine("BEM-VINDO AO JOGO DA VELHA!!\n");
        Console.WriteLine("Informe o nome do Jogador 1 (X)");
        jogador1.nome = Console.ReadLine();
        Console.WriteLine("Informe o nome do Jogador 2 (O)");
        jogador2.nome = Console.ReadLine();

        Console.WriteLine($"\nBem-vindos {jogador1.nome} e {jogador2.nome}, aperte qualquer tecla para iniciar o jogo");
        Console.Read();
    }

    public void Verifica()
    {
        tabuleiro.Exibir();
        for (int i = 0; i < 3; i++)
        {
            if (ChecaColuna(i))
            {
                JogadorXVenceu(tabuleiro.casa[0, i]);
                break;
            }
            else if (ChecaLinha(i))
            {
                JogadorXVenceu(tabuleiro.casa[i, 0]);
                break;
            }
            else if (ChecaDiagonalPrincipal())
            {
                JogadorXVenceu(tabuleiro.casa[i, i]);
                break;
            }
            else if (ChecaDiagonalSecundária())
            {
                JogadorXVenceu(tabuleiro.casa[2, 0]);
                break;
            }
            else if (ChecaEmpate())
            {
                Empate();
                break;
            }
        }

    }
    private void Finalizar(string? vencedor)
    {
        if (vencedor != null)
            Console.WriteLine($"{vencedor} Venceu!!! Parabéns!");
        else
            Console.WriteLine("Empate!");

        FimDoJogo = true;
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

    #region Checagens
    private bool ChecaLinha(int i)
    {
        return tabuleiro.casa[i, 0] == tabuleiro.casa[i, 1] && tabuleiro.casa[i, 1] == tabuleiro.casa[i, 2] && tabuleiro.casa[i, 0] != ' ';
    }
    private bool ChecaColuna(int i)
    {
        return tabuleiro.casa[0, i] == tabuleiro.casa[1, i] && tabuleiro.casa[1, i] == tabuleiro.casa[2, i] && tabuleiro.casa[0, i] != ' ';
    }
    private bool ChecaDiagonalPrincipal()
    {
        return tabuleiro.casa[0, 0] == tabuleiro.casa[1, 1] && tabuleiro.casa[1, 1] == tabuleiro.casa[2, 2] && tabuleiro.casa[0, 0] != ' ';
    }
    private bool ChecaDiagonalSecundária()
    {
        return tabuleiro.casa[2, 0] == tabuleiro.casa[1, 1] && tabuleiro.casa[1, 1] == tabuleiro.casa[0, 2] && tabuleiro.casa[2, 0] != ' ';
    }
    private bool ChecaEmpate()
    {
        int check = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (tabuleiro.casa[i, j] != ' ') check++;
            }
        }
        if (check == 9) return true;
        else return false;
    }
    #endregion
}
