using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ZU GA TAKAI ZO!
/// </summary>
public class ImperialPresence : HabilidadeOfensiva
{
    public override void AttackAction(Player target)
    {
        base.AttackAction(player);

        player.diceNumber = GameManager.D6Roll();
        player.CallPlayerEffects();

        if (player.diceNumber < 2)
            return;

        if(player.missoes.Count < 3)
        {
            var missao = target.missoes[new System.Random().Next() % target.missoes.Count];
            target.missoes.Remove(missao);
            player.missoes.Add(missao);
        }

        var habilidade = target.habilidades[new System.Random().Next() % target.habilidades.Count];
        target.habilidades.Remove(habilidade);
        player.habilidades.Add(habilidade);
    }
}
