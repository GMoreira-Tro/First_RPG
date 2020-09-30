using System.Collections.Generic;
using UnityEngine;

public class CardsStack : MonoBehaviour
{
    public List<GameObject> habilidadesGO;
    public List<GameObject> missoesGO;

    public GameObject DrawSkillCard(Player player)
    {
        //Puxando uma carta de índice aleatório da lista
        int cardIndex = new System.Random().Next() % habilidadesGO.Count;
        //Salvando a carta numa variável para retorná-la
        var GO = habilidadesGO[cardIndex];
        //Atribuindo a carta ao jogador
        player.habilidades.Add(GO.GetComponent<Habilidade>());
        //Removendo a carta da pilha
        habilidadesGO.RemoveAt(cardIndex);

        return GO;
    }

    public GameObject DrawMissionCard(Player player)
    {
        //Puxando uma carta de índice aleatório da lista
        int cardIndex = new System.Random().Next() % missoesGO.Count;
        //Salvando a carta numa variável para retorná-la
        var GO = missoesGO[cardIndex];
        //Atribuindo a carta ao jogador
        player.missoes.Add(missoesGO[cardIndex].GetComponent<Missao>());
        //Removendo a carta da pilha
        missoesGO.RemoveAt(cardIndex);

        return GO;
    }
}
