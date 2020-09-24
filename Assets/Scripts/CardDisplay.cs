using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public CharacterCard card;
    public Text classe;
    public Text descricao;
    public Text habilidade;
    public SpriteRenderer artwork;

    void Start()
    {
        classe.text = card.classe.ToString();
        descricao.text = card.descricao;
        //habilidade.text = card.habilidade;
        artwork.sprite = card.artwork;
    }
}
