using System;
using System.Collections.Generic;

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
    /// Lista de cartas de habilidade na pilha de colecionáveis
    /// </summary>
    public static List<Habilidade> habilidadeCards;
    /// <summary>
    /// Lista de cartas de missão na pilha de colecionáveis
    /// </summary>
    public static List<Missao> missaoCards;

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

    /// <summary>
    /// Inicializar a lista de habilidades e missões com todas as cartas
    /// </summary>
    public static void Init()
    {
        InitSkillCards();
        InitMissionCards();
    }

    /// <summary>
    /// Inicializar as habilidades
    /// </summary>
    private static void InitSkillCards()
    {
        habilidadeCards = new List<Habilidade>();

        //Primeira habilidade
        habilidadeCards.Add(new Habilidade(1, 0,
        () =>
        {
        
        }));
        //Segunda habilidade
        habilidadeCards.Add(new Habilidade(1, 1,
        () =>
        {

        }));
        //Terceira habilidade
        habilidadeCards.Add(new Habilidade(1, 2,
        () =>
        {

        }));
        //Quarta habilidade
        habilidadeCards.Add(new Habilidade(1, 3,
        () =>
        {

        }));
        //Quinta habilidade
        habilidadeCards.Add(new Habilidade(1, 4,
        () =>
        {

        }));
        //Sexta habilidade
        habilidadeCards.Add(new Habilidade(1, 5,
        () =>
        {

        }));
        //Sétima habilidade
        habilidadeCards.Add(new Habilidade(1, 6,
        () =>
        {

        }));
        //Oitava habilidade
        habilidadeCards.Add(new Habilidade(1, 7,
        () =>
        {

        }));
        //Nona habilidade
        habilidadeCards.Add(new Habilidade(1, 8,
        () =>
        {

        }));
        //Décima habilidade
        habilidadeCards.Add(new Habilidade(1, 9,
        () =>
        {

        }));
        //Décima primeira habilidade
        habilidadeCards.Add(new Habilidade(1, 10,
        () =>
        {

        }));
        //Décima segunda habilidade
        habilidadeCards.Add(new Habilidade(1, 11,
        () =>
        {

        }));
        //Décima terceira habilidade
        habilidadeCards.Add(new Habilidade(1, 12,
        () =>
        {

        }));
        //Décima quarta habilidade
        habilidadeCards.Add(new Habilidade(1, 13,
        () =>
        {

        }));
        //Décima quinta habilidade
        habilidadeCards.Add(new Habilidade(1, 14,
        () =>
        {

        }));
        //Décima sexta habilidade
        habilidadeCards.Add(new Habilidade(1, 15,
        () =>
        {

        }));
        //Décima sétima habilidade
        habilidadeCards.Add(new Habilidade(1, 16,
        () =>
        {

        }));
        //Décima oitava habilidade
        habilidadeCards.Add(new Habilidade(1, 17,
        () =>
        {

        }));
        //Décima nona habilidade
        habilidadeCards.Add(new Habilidade(1, 18,
        () =>
        {

        }));
        //Vigésima habilidade
        habilidadeCards.Add(new Habilidade(1, 19,
        () =>
        {

        }));
        //Vigésima primeira habilidade
        habilidadeCards.Add(new Habilidade(1, 20,
        () =>
        {

        }));
        //Vigésima segunda habilidade
        habilidadeCards.Add(new Habilidade(1, 21,
        () =>
        {

        }));
        //Vigésima terceira habilidade
        habilidadeCards.Add(new Habilidade(1, 22,
        () =>
        {

        }));
        //Vigésima quarta habilidade
        habilidadeCards.Add(new Habilidade(1, 23,
        () =>
        {

        }));
        //Vigésima quinta habilidade
        habilidadeCards.Add(new Habilidade(1, 24,
        () =>
        {

        }));
        //Vigésima sexta habilidade
        habilidadeCards.Add(new Habilidade(1, 25,
        () =>
        {

        }));
        //Vigésima sétima habilidade
        habilidadeCards.Add(new Habilidade(1, 26,
        () =>
        {

        }));
        //Vigésima oitava habilidade
        habilidadeCards.Add(new Habilidade(1, 27,
        () =>
        {

        }));
        //Vigésima nona habilidade
        habilidadeCards.Add(new Habilidade(1, 28,
        () =>
        {

        }));
        //Trigésima habilidade
        habilidadeCards.Add(new Habilidade(1, 29,
        () =>
        {

        }));
        //Trigésima primeira habilidade
        habilidadeCards.Add(new Habilidade(1, 30,
        () =>
        {

        }));

    }

    /// <summary>
    /// Inicializar as missões
    /// </summary>
    private static void InitMissionCards()
    {
        //missaoCards = new List<MissaoCard>();

    }
}
