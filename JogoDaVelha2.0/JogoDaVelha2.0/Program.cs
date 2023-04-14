using JogoDaVelha2._0.Classes;

Tabuleiro tabuleiro = new();
Jogador1 jogador1 = new(tabuleiro);
Jogador2 jogador2 = new(tabuleiro);
Juiz juiz = new(tabuleiro, jogador1, jogador2);

juiz.Iniciar();

while (!juiz.fimDoJogo)
{
    tabuleiro.Exibir();

    
    if (juiz.VezJogador1)
    {
        Console.WriteLine($"{juiz.nomeJog1}, sua vez.");
        jogador1.Jogar();
    }
    else
    {
        Console.WriteLine($"{juiz.nomeJog2}, sua vez.");
        jogador2.Jogar();
    }
    
}