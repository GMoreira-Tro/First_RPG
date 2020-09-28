using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcaneIntellect : HabilidadeOfensiva
{
    public override void SelfAction()
    {
        base.SelfAction();

        int effectIndex = player.effects.Count;
        player.effects.Add(() =>
        {
            player.diceNumber = 6;
            player.effects.RemoveAt(effectIndex);
        });
    }
}
