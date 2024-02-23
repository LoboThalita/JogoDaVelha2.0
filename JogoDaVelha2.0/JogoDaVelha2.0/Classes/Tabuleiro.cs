namespace JogoDaVelha2._0.Classes;

public class Tabuleiro
{
    public char[,] casa = new char[3, 3];

    //Quando o tabuleiro é instanciado é atribuido vazio para todas as casas
    public Tabuleiro()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                casa[i, j] = ' ';
            }
        }
    }

    public void Exibir()
    {
        Console.Clear();

        Console.WriteLine("   0   1   2");
        Console.WriteLine("0  {0} | {1} | {2} ", casa[0, 0], casa[0, 1], casa[0, 2]);
        Console.WriteLine("  ---+---+---");
        Console.WriteLine("1  {0} | {1} | {2} ", casa[1, 0], casa[1, 1], casa[1, 2]);
        Console.WriteLine("  ---+---+---");
        Console.WriteLine("2  {0} | {1} | {2} ", casa[2, 0], casa[2, 1], casa[2, 2]);
        Console.WriteLine();
    }

    public void ColocarPeca(int linha, int coluna, char p)
    {
        if (linha >= 0 && coluna >= 0 && linha < 3 && coluna < 3)
            if (casa[linha, coluna] == ' ')
                casa[linha, coluna] = p;
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
