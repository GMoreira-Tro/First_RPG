using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbortMission : HabilidadeDefensiva
{
    public override void CounterAction()
    {
        base.CounterAction();

        player.diceNumber = GameManager.D6Roll();

        if (player.diceNumber < 2 || player.missoes.Count == 0)
            return;

        var missao = player.missoes[new System.Random().Next() % player.missoes.Count];
        player.missoes.Remove(missao);

        player.effects.RemoveAt(player.effects.Count - 1);
    }
}
