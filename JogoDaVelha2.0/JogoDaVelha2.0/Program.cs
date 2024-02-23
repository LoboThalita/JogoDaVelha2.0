using JogoDaVelha2._0.Classes;

//Instancializando objetos para jogo
Tabuleiro tabuleiro = new();
Jogador1 jogador1 = new(tabuleiro);
Jogador2 jogador2 = new(tabuleiro);
Juiz juiz = new(tabuleiro, jogador1, jogador2);

juiz.Iniciar();

while (!juiz.FimDoJogo)
{
    tabuleiro.Exibir();
    
    //Juiz verifica de quem é a vez e o respectivo jogador joga
    if (juiz.VezJogador1)
    {
        Console.WriteLine($"{jogador1.nome}, sua vez.");
        jogador1.Jogar();
    }
    else
    {
        Console.WriteLine($"{jogador2.nome}, sua vez.");
        jogador2.Jogar();
    }

    //Juiz verifica se há algum vencedor, caso haja o juiz.FimDoJogo recebe True e juiz finaliza partida,
    //Caso não, jogo continua normalmente.
    juiz.Verifica();
}

Console.WriteLine("\nObrigado por jogar! Volte sempre");