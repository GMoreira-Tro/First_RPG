using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivineSign : HabilidadeOfensiva
{
    public override void SelfAction()
    {
        base.SelfAction();

        player.diceNumber = GameManager.D6Roll();
        player.CallPlayerEffects();

        if (player.diceNumber < 3)
            return;

        player.passos += 4;
    }
}
