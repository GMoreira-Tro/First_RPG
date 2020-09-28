using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WishRing : HabilidadeDefensiva
{
    public override void CounterAction()
    {
        base.CounterAction();

        player.diceNumber = GameManager.D6Roll();

        if (player.diceNumber < 5)
            return;

        player.effects.RemoveAt(player.effects.Count - 1);

    }
}
