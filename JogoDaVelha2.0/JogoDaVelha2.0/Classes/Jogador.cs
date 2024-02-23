namespace JogoDaVelha2._0.Classes;

public abstract class Jogador
{
    private readonly Tabuleiro tabuleiro;
    public char peca { get; set; } = ' ';
    public string nome { get; set; }

    public Jogador(Tabuleiro tabuleiro)
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
