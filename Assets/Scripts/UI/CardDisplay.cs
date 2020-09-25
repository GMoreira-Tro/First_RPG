using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public CharacterCard card;
    public Text classe;
    public Text descricao;
    public SpriteRenderer artwork;

    void Start()
    {
        classe.text = card.classe.ToString();
        descricao.text = card.descricao;
        artwork.sprite = card.artwork;
    }
}
