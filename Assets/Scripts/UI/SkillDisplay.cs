using UnityEngine;

public class SkillDisplay : MonoBehaviour
{
    public int indiceHabilidade;

    private Habilidade habilidade;

    void Start()
    {
        habilidade = GameManager.habilidadeCards[indiceHabilidade];
    }
}
