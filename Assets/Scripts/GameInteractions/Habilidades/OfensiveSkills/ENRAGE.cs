using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENRAGE : HabilidadeOfensiva
{
    public override void AttackAction(Player target)
    {
        base.AttackAction(target);

        player.diceNumber = GameManager.D6Roll();
        player.CallPlayerEffects();

        if (player.diceNumber < 5 || player.missoes.Count > 2)
            return;

        var missao = target.missoes[new System.Random().Next() % target.missoes.Count];
        target.missoes.Remove(missao);
        player.missoes.Add(missao);
    }
}
