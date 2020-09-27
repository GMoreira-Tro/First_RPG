using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bribery : HabilidadeOfensiva
{
    public override void AttackAction(Player target)
    {
        player.diceNumber += GameManager.D6Roll();

        if (player.diceNumber >= 2)
        {
            target.diceNumber -= 3;
        }

        player.diceNumber = 0;
    }
}
