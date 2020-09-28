using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondDust : HabilidadeOfensiva
{
    public override void AttackAction(Player target)
    {
        base.AttackAction(target);

        player.diceNumber = GameManager.D6Roll();
        player.CallPlayerEffects();

        if (player.diceNumber < 5)
            return;

        int effectIndex = target.effects.Count;
        target.effects.Add(() =>
        {
            target.diceNumber = 0;
            target.futureEffects.Add(() => {
                int effectIndexFuture = target.effects.Count;
                target.diceNumber = 0;
                target.effects.RemoveAt(effectIndexFuture);
            });
            target.effects.RemoveAt(effectIndex);
        });
    }
}
