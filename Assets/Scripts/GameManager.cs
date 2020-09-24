using System;
using System.Collections.Generic;

public static class GameManager
{
    public static Player[] players;
    public static int activePlayerIndex;
    public static List<HabilidadeCard> habilidadeCards = new List<HabilidadeCard>();
    public static List<MissaoCard> missaoCards = new List<MissaoCard>();

    public static int D6Roll() {
        return new Random().Next(1,6);
    }
    public static int D10Roll()
    {
        return new Random().Next(1, 10);
    }
    public static int D20Roll()
    {
        return new Random().Next(1, 20);
    }
}
