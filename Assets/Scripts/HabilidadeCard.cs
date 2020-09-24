using UnityEngine;

[CreateAssetMenu]
public class HabilidadeCard : ScriptableObject
{
    public Sprite artwork;
    public string descricao;
    public int nivelDeDificuldade;
    public Action action;

    public delegate void Action();

    public void SetAction(Action action)
    {
        this.action = action;
    }
    public void CallAction()
    {
        action();
    }
}
