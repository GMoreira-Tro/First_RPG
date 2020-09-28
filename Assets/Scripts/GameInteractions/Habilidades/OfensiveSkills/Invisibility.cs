using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisibility : HabilidadeOfensiva
{
    public override void AttackAction(Player target)
    {
        base.AttackAction(target);

        player.diceNumber = GameManager.D6Roll();
        player.CallPlayerEffects();

        if (player.diceNumber < 3)
            return;

        if (player.missoes.Count < 3)
        {
            var missao = target.missoes[new System.Random().Next() % target.missoes.Count];
            target.missoes.Remove(missao);
            player.missoes.Add(missao);
        }
    }
}
