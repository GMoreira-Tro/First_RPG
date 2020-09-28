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
    [HideInInspector]
    public int passos = 0;
    [HideInInspector]
    public int habilitiesSlot = 3;
    [HideInInspector]
    public int missionsSlot = 3;

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
    public List<Effect> effects = new List<Effect>();
    /// <summary>
    /// Efeitos perdurantes que ativaram no próximo turno
    /// </summary>
    public List<Effect> futureEffects = new List<Effect>();

    public delegate void Effect();

    public void SetPlayer(Classe classe, Sprite characterSprite)
    {
        this.classe = classe;
        this.characterSprite = characterSprite;
    }

    public void CallPlayerEffects()
    {
        foreach(var effect in effects)
            effect();
    }

    public void ResetPlayerEffects()
    {
        effects.Clear();
    }

    public void MoveFutureEffects()
    {
        foreach(var effect in futureEffects)
        {
            effects.Add(effect);
        }
        futureEffects.Clear();
    }
}
