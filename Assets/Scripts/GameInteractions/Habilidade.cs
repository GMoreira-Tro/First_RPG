using UnityEngine;

public abstract class Habilidade : MonoBehaviour
{
    [HideInInspector]
    public int diceNumber { get; protected set; }

    public virtual void CallAction()
    {

    }
}
