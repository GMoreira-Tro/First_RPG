using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour
{
    /// <summary>
    /// Ponto para o jogador transladar para
    /// </summary>
    private Transform movePoint;
    /// <summary>
    /// Tempo em segundos para atualizar a posição do personagem
    /// </summary>
    private const float step = 0.4f;
    /// <summary>
    /// O jogador do gameObject em questão
    /// </summary>
    private Player player;

    private void Start()
    {
        player = gameObject.GetComponent<Player>();
        movePoint = gameObject.transform;
        StartCoroutine(UpdatePlayerPosition());
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, Time.deltaTime);
    }

    /// <summary>
    /// Coroutina para atualizar a posição do Player, de acordo com os direcionais W,A,S,D clicados
    /// </summary>
    /// <returns></returns>
    private IEnumerator UpdatePlayerPosition()
    {
        while(player.passos > 0) {
            if (Vector3.Distance(transform.position, movePoint.position) <= 0.01f)
            {
                if(Input.GetKey(KeyCode.D))
                {
                    movePoint.position += new Vector3(2, 0, 0);
                    player.passos--;
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    movePoint.position += new Vector3(-2, 0, 0);
                    player.passos--;
                }
                else if (Input.GetKey(KeyCode.W))
                {
                    movePoint.position += new Vector3(0, 0.82f, 0);
                    player.passos--;
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    movePoint.position += new Vector3(0, -0.82f, 0);
                    player.passos--;
                }
            }
            yield return new WaitForSeconds(step);
        }
    }
}
