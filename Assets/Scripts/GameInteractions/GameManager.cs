using System;

/// <summary>
/// Classe ESTÁTICA que guarda os dados do jogo e funções de gameplay
/// </summary>
public static class GameManager
{
    /// <summary>
    /// Jogadores que irão jogar a partida
    /// </summary>
    public static Player[] players;
    /// <summary>
    /// Jogador ativo no turno
    /// </summary>
    public static int activePlayerIndex;

    /// <summary>
    /// Sortear um número aleatório (1 a 6)
    /// </summary>
    /// <returns> número retornado </returns>
    public static int D6Roll() {
        return new Random().Next(1,6);
    }
    /// <summary>
    /// Sortear um número aleatório (1 a 10)
    /// </summary>
    /// <returns> número retornado </returns>
    public static int D10Roll()
    {
        return new Random().Next(1, 10);
    }
    /// <summary>
    /// Sortear um número aleatório (1 a 20)
    /// </summary>
    /// <returns> número retornado </returns>
    public static int D20Roll()
    {
        return new Random().Next(1, 20);
    }
}
