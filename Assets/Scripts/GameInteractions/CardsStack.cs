using System.Collections.Generic;
using UnityEngine;

public class CardsStack : MonoBehaviour
{
    public List<GameObject> habilidadesGO;
    public List<GameObject> missoesGO;

    public Habilidade DrawSkillCard(Player player)
    {
        //Puxando uma carta de índice aleatório da lista
        int cardIndex = new System.Random().Next() % habilidadesGO.Count;
        //Salvando a carta numa variável para retorná-la
        var habilidade = habilidadesGO[cardIndex].GetComponent<Habilidade>();
        //Atribuindo a carta ao jogador
        player.habilidades.Add(habilidade);
        //Removendo a carta da pilha
        habilidadesGO.RemoveAt(cardIndex);

        return habilidade;
    }

    public Missao DrawMissionCard(Player player)
    {
        //Puxando uma carta de índice aleatório da lista
        int cardIndex = new System.Random().Next() % missoesGO.Count;
        //Salvando a carta numa variável para retorná-la
        var missao = missoesGO[cardIndex].GetComponent<Missao>();
        //Atribuindo a carta ao jogador
        player.missoes.Add(missao);
        //Removendo a carta da pilha
        missoesGO.RemoveAt(cardIndex);

        return missao;
    }
}
