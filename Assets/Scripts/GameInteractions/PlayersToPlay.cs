using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersToPlay : MonoBehaviour
{
    public static Player[] players;
    public static PlayerTurn[] playersTurns;

    void Start()
    {
        players = new Player[GameManager.players.Length];
        playersTurns = new PlayerTurn[GameManager.players.Length];

        for (int i = 0; i < players.Length; i++)
        {
            //Instanciando um Game Object para cada jogador
            var playerGO = new GameObject();
            //Adicionando um componente Player para cada game Object
            players[i] = playerGO.AddComponent<Player>();

            //Adicionando o Scritpt de controle de turno ao Player
            playersTurns[i] = playerGO.AddComponent<PlayerTurn>();
            //Setando a classe do Player
            players[i].SetPlayer(GameManager.players[i].classe);

            //Setando a sprite do Player
            var spriteRenderer = playerGO.AddComponent<SpriteRenderer>();
            spriteRenderer.sprite = GameManager.players[i].characterSprite;
            //Setando a escala do Player
            playerGO.gameObject.transform.localScale = new Vector2(0.2f, 0.2f);
            
            //Setando as posições onde cada Player deve nascer
            switch (i)
            {
                case 0:
                    playerGO.gameObject.transform.position = new Vector3(0.5f, 1.5f);
                    break;
                case 1:
                    playerGO.gameObject.transform.position = new Vector3(-1.5f, 1.5f);
                    break;
                case 2:
                    playerGO.gameObject.transform.position = new Vector3(0.5f, -0.9f);
                    break;
                default:
                    playerGO.gameObject.transform.position = new Vector3(-1.5f, -0.9f);
                    break;
            }
        }

        //Desativando o Player turn de todos os jogadores que não o primeiro
        for (int i = 1; i < playersTurns.Length; i++)
        {
            playersTurns[i].enabled = false;
        }
    }

    public static void EndPlayerTurn()
    {
        for (int i = 1; i < playersTurns.Length; i++)
        {
            playersTurns[i].enabled = true;
        }
        playersTurns[GameManager.activePlayerIndex].enabled = false;

        GameManager.activePlayerIndex = (GameManager.activePlayerIndex + 1) % players.Length;
    }
}
