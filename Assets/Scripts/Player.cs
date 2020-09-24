using System.Collections.Generic;
using UnityEngine;

public class Player
{
    [HideInInspector]
    public Classe classe { get; private set; }
    [HideInInspector]
    public Sprite characterSprite { get; private set; }
    private List<HabilidadeCard> habilidades = new List<HabilidadeCard>();
    private List<MissaoCard> missoes = new List<MissaoCard>();

    public Player(Classe classe, Sprite characterSprite)
    {
        this.classe = classe;
        this.characterSprite = characterSprite;
    }
}
