using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMaiden : HabilidadeOfensiva
{
    public override void AttackAction(Player target)
    {
        base.AttackAction(target);

        player.diceNumber = GameManager.D6Roll();
        player.CallPlayerEffects();

        if (player.diceNumber < 2)
            return;

        int effectIndex = target.effects.Count;
        target.effects.Add(() =>
        {
            target.diceNumber -= 2;
            target.effects.RemoveAt(effectIndex);
        });
    }
}
