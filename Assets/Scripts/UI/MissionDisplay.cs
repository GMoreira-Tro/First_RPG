using UnityEngine;

public class MissionDisplay : MonoBehaviour
{
    public int indiceMissao;

    private Missao missao;

    void Start()
    {
        missao = GameManager.missaoCards[indiceMissao];
    }
}
