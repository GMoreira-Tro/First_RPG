using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulCalibur : HabilidadeOfensiva
{
    public override void SelfAction()
    {
        base.SelfAction();

        player.diceNumber = GameManager.D6Roll();
        player.CallPlayerEffects();

        if (player.diceNumber < 2)
            return;

        if(player.missoes.Count > 0) {
            player.missoes.RemoveAt(new System.Random().Next() % player.missoes.Count);
            player.passos += 2;
        }
    }
}
