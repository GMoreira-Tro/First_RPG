using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// <summary>
    /// Classe do personagem
    /// </summary>
    [HideInInspector]
    public Classe classe { get; private set; }
    [HideInInspector]
    public Sprite characterSprite { get; private set; }
    [HideInInspector]
    public int diceNumber = 0;

    /// <summary>
    /// Lista de habilidades coletadas pelo jogador
    /// </summary>
    public List<Habilidade> habilidades = new List<Habilidade>();
    /// <summary>
    /// Lista de missões coletadas pelo jogador
    /// </summary>
    public List<Missao> missoes = new List<Missao>();
    
    /// <summary>
    /// Buffs e debuffs que os jogadores sofrerão no início de seus turnos
    /// </summary>
    public Effect effects;
    public delegate void Effect();

    public void SetPlayer(Classe classe, Sprite characterSprite)
    {
        this.classe = classe;
        this.characterSprite = characterSprite;
    }

    public void CallPlayerEffects()
    {
        effects();
    }
}
