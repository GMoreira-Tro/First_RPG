using UnityEngine;

public class Habilidade
{
    public int nivelDeDificuldade;
    public int indiceDaCarta;
    public Action action;

    public delegate void Action();

    public Habilidade(int nivelDeDificuldade, int indiceDaCarta, Action action)
    {
        this.nivelDeDificuldade = nivelDeDificuldade;
        this.indiceDaCarta = indiceDaCarta;
        this.action = action;
    }
    public void CallAction()
    {
        action();
    }
}
