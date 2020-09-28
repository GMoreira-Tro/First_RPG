using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersToPlay : MonoBehaviour
{
    public GameObject[] playersGO;

    void Start()
    {
        playersGO = new GameObject[GameManager.players.Length];
        
        for (int i = 0; i < playersGO.Length; i++)
        {
            playersGO[i] = new GameObject();
            var player = playersGO[i].AddComponent<Player>();
            player.SetPlayer(GameManager.players[i].classe, GameManager.players[i].characterSprite);

            var spriteRenderer = playersGO[i].AddComponent<SpriteRenderer>();
            spriteRenderer.sprite = GameManager.players[i].characterSprite;
            playersGO[i].gameObject.transform.localScale = new Vector2(0.2f, 0.2f);

            switch (i)
            {
                case 0:
                    playersGO[i].gameObject.transform.position = new Vector3(0.5f, 1.5f);
                    break;
                case 1:
                    playersGO[i].gameObject.transform.position = new Vector3(-1.5f, 1.5f);
                    break;
                case 2:
                    playersGO[i].gameObject.transform.position = new Vector3(0.5f, -1);
                    break;
                default:
                    playersGO[i].gameObject.transform.position = new Vector3(-1.5f, -1);
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
