using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcsRush : HabilidadeOfensiva
{
    public override void AttackAction(Player target)
    {
        base.AttackAction(player);

        player.diceNumber = GameManager.D6Roll();
        player.CallPlayerEffects();

        if (player.diceNumber < 5)
            return;

    }
}
