﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinraTensei : Habilidade
{
    public override void CallAction()
    {
        diceNumber = GameManager.D6Roll();
        if (diceNumber < 2)
            return;

    }
}
