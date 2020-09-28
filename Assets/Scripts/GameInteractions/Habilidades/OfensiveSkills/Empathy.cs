using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empathy : HabilidadeOfensiva
{
    public override void SelfAction()
    {
        base.SelfAction();

        player.diceNumber = GameManager.D6Roll();
        player.CallPlayerEffects();

        if (player.diceNumber < 2)
            return;

        player.passos += 2;
    }
}
