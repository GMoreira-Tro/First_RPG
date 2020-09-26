using System.Collections.Generic;
using UnityEngine;

public class Player
{
    /// <summary>
    /// Classe do personagem
    /// </summary>
    [HideInInspector]
    public Classe classe { get; private set; }
    [HideInInspector]
    public Sprite characterSprite { get; private set; }

    /// <summary>
    /// Lista de habilidades coletadas pelo jogador
    /// </summary>
    public List<Habilidade> habilidades = new List<Habilidade>();
    /// <summary>
    /// Lista de missões coletadas pelo jogador
    /// </summary>
    public List<Missao> missoes = new List<Missao>();

    public Player(Classe classe, Sprite characterSprite)
    {
        this.classe = classe;
        this.characterSprite = characterSprite;
    }
}
