using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENRAGE : HabilidadeOfensiva
{
    public override void CallAction()
    {
        diceNumber = GameManager.D6Roll();
        if (diceNumber < 5)
            return;

    }
}
