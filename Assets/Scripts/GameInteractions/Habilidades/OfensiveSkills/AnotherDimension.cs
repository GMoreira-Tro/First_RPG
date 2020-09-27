using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherDimension : HabilidadeOfensiva
{
    public override void AttackAction(Player target)
    {
        player.diceNumber += GameManager.D6Roll();

        if (player.diceNumber >= 5) {
            var aux = player.transform.position;
            player.transform.position = target.transform.position;
            target.transform.position = aux;
        }

        player.diceNumber = 0;
    }
}
