using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcaneIntellect : HabilidadeOfensiva
{
    public override void SelfAction()
    {
        player.effects += () =>
        {
            player.diceNumber = 6;
        };
    }
}
