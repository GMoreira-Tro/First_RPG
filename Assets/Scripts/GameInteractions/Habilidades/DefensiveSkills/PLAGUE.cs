using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAGUE : HabilidadeDefensiva
{
    public override void ReflectAction(Player target)
    {
        base.ReflectAction(target);

        player.diceNumber = GameManager.D6Roll();

        if (player.diceNumber < 3)
            return;

        int count = (player.effects.Count - 1);
        var effect = player.effects[count];

        player.effects.RemoveAt(count);
        target.effects.Add(effect);

    }
}
