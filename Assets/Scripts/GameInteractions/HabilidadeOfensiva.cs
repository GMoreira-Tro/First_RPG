using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HabilidadeOfensiva : Habilidade
{
    public virtual void AttackAction(Player target)
    {
        player.habilidades.Remove(this);
        GameObject.Find("DiscardStack").GetComponent<CardsStack>().habilidades.Add(this);
    }

    public virtual void SelfAction()
    {
        player.habilidades.Remove(this);
        GameObject.Find("DiscardStack").GetComponent<CardsStack>().habilidades.Add(this);
    }
}
