using System.Collections.Generic;
using UnityEngine;

public class CardsStack : MonoBehaviour
{
    public List<Habilidade> habilidades;
    public List<Missao> missoes;

    public void DrawSkillCard(Player player)
    {
        //Puxando uma carta de índice aleatório da lista
        int cardIndex = new System.Random().Next() % habilidades.Count;
        //Atribuindo a carta ao jogador
        player.habilidades.Add(habilidades[cardIndex]);
        //Removendo a carta da pilha
        habilidades.RemoveAt(cardIndex);
    }

    public void DrawMissionCard(Player player)
    {
        //Puxando uma carta de índice aleatório da lista
        int cardIndex = new System.Random().Next() % missoes.Count;
        //Atribuindo a carta ao jogador
        player.missoes.Add(missoes[cardIndex]);
        //Removendo a carta da pilha
        missoes.RemoveAt(cardIndex);
    }
}
