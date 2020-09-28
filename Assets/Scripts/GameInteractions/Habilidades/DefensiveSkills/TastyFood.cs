﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TastyFood : HabilidadeDefensiva
{
    public override void CounterAction()
    {
        base.CounterAction();

        player.diceNumber = GameManager.D6Roll();

        if (player.diceNumber < 2)
            return;

        player.effects.RemoveAt(player.effects.Count - 1);

    }
}
