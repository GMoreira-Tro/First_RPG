using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HabilidadeDefensiva : Habilidade
{
    public virtual void ReflectAction(Player target)
    {
        player.habilidades.Remove(this);
        GameObject.Find("DiscardStack").GetComponent<CardsStack>().habilidades.Add(this);
    }
    public virtual void CounterAction()
    {
        player.habilidades.Remove(this);
        GameObject.Find("DiscardStack").GetComponent<CardsStack>().habilidades.Add(this);
    }
}
