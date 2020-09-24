using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterCard character;
    private List<HabilidadeCard> habilidades = new List<HabilidadeCard>();
    private List<MissaoCard> missoes = new List<MissaoCard>();

    public Player(CharacterCard character)
    {
        this.character = character;
    }
}
