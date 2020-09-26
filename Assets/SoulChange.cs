using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulChange : Habilidade
{
    public override void CallAction()
    {
        diceNumber = GameManager.D6Roll();
        if (diceNumber < 3)
            return;

    }
}
