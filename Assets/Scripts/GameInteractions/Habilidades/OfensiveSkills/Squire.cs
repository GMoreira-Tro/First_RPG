using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squire : HabilidadeOfensiva
{
    public override void SelfAction()
    {
        base.SelfAction();

        player.diceNumber = GameManager.D6Roll();
        player.CallPlayerEffects();

        if (player.diceNumber < 3)
            return;

        int effectIndex = player.effects.Count;
        player.effects.Add(() =>
        {
            player.habilitiesSlot++;
            player.effects.RemoveAt(effectIndex);
        });
    }
}
