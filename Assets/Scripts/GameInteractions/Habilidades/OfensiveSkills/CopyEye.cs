using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyEye : HabilidadeOfensiva
{
    public override void SelfAction()
    {
        base.SelfAction();

        player.diceNumber = GameManager.D6Roll();
        player.CallPlayerEffects();

        if (player.diceNumber < 3)
            return;

        var discardStackHabilities = GameObject.Find("DiscardStack").GetComponent<CardsStack>().habilidades;
        try {
            player.habilidades.Add(discardStackHabilities[discardStackHabilities.Count-1]);
        }
        catch(System.IndexOutOfRangeException) { }
    }
}
