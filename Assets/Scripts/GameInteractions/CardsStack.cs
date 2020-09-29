using System.Collections.Generic;
using UnityEngine;

public class CardsStack : MonoBehaviour
{
    public List<GameObject> habilidadesGO;
    public List<GameObject> missoesGO;

    public void DrawSkillCard(Player player)
    {
        //Puxando uma carta de índice aleatório da lista
        int cardIndex = new System.Random().Next() % habilidadesGO.Count;
        //Atribuindo a carta ao jogador
        player.habilidades.Add(habilidadesGO[cardIndex].GetComponent<Habilidade>());
        //Removendo a carta da pilha
        habilidadesGO.RemoveAt(cardIndex);
    }

    public void DrawMissionCard(Player player)
    {
        //Puxando uma carta de índice aleatório da lista
        int cardIndex = new System.Random().Next() % missoesGO.Count;
        //Atribuindo a carta ao jogador
        player.missoes.Add(missoesGO[cardIndex].GetComponent<Missao>());
        //Removendo a carta da pilha
        missoesGO.RemoveAt(cardIndex);
    }
}
