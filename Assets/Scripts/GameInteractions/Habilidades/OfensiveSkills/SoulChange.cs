using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulChange : HabilidadeOfensiva
{
    public override void AttackAction(Player target)
    {
        base.SelfAction();

        player.diceNumber = GameManager.D6Roll();
        player.CallPlayerEffects();

        if (player.diceNumber < 3 || player.habilidades.Count == 0)
            return;

        var targetSkill = target.habilidades[new System.Random().Next() % target.habilidades.Count];
        var playerSkill = player.habilidades[new System.Random().Next() % player.habilidades.Count];

        target.habilidades.Remove(targetSkill);
        target.habilidades.Add(playerSkill);

        player.habilidades.Remove(playerSkill);
        player.habilidades.Add(targetSkill);
    }
}
