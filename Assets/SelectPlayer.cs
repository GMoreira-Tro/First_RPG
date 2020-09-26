using UnityEngine;

public class SelectPlayer : MonoBehaviour
{
    public AudioSource buttonAudio;
    /// <summary>
    /// Selecionar o personagem para o jogador em questão no OnMouseUp
    /// </summary>
    private void OnMouseUp()
    {
        buttonAudio.Play();
        var card = GetComponent<CardDisplay>().card;
        GameManager.players[GameManager.activePlayerIndex] = new Player(card.classe, card.artwork);
        GameManager.activePlayerIndex = (GameManager.activePlayerIndex + 1) % GameManager.players.Length;

        if (GameManager.activePlayerIndex == 0)
        {
            SceneController.LoadSceneDestroyingMusic("Game");
        }

        gameObject.SetActive(false);
    }
}
