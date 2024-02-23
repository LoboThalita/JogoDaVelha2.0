namespace JogoDaVelha2._0.Classes;

public class Jogador
{
    private readonly Tabuleiro tabuleiro;
    public readonly char peca;
    public string nome { get; set; }

    public Jogador(Tabuleiro tabuleiro, char peca)
    {
        this.tabuleiro = tabuleiro;
        this.peca = peca;
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
