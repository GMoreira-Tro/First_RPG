using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour
{
    /// <summary>
    /// O jogador do gameObject em questão
    /// </summary>
    private Player player;

    private PlayersToPlay playersManager;
    private TurnHud turnHud;

    private void OnEnable()
    {
       turnHud = playersManager.InstantiateTurnHud(gameObject.transform).GetComponent<TurnHud>();
       turnHud.InitializeTurnHud(player);
    }
    private void OnDisable()
    {
        Destroy(turnHud.gameObject);
    }

    private void Awake()
    {
        player = gameObject.GetComponent<Player>();
        playersManager = GameObject.Find("PlayersManager").GetComponent<PlayersToPlay>();
        //StartCoroutine(UpdatePlayerPosition());
    }

    public static void EndPlayerTurn()
    {
        PlayersToPlay.playersTurns[GameManager.activePlayerIndex].enabled = false;

        GameManager.activePlayerIndex = (GameManager.activePlayerIndex + 1) % PlayersToPlay.players.Length;

        PlayersToPlay.playersTurns[GameManager.activePlayerIndex].enabled = true;
    }
}
