using UnityEngine;

public class SelectPlayer : MonoBehaviour
{
    /// <summary>
    /// Áudio do botão a disparar quando selecionar um personagem
    /// </summary>
    public AudioSource buttonAudio;
    /// <summary>
    /// O emissor de luz da carta
    /// </summary>
    public Light lightEmissor;

    /// <summary>
    /// Selecionar o personagem para o jogador em questão no OnMouseUp
    /// </summary>
    private void OnMouseUp()
    {
        buttonAudio.Play();
        var card = GetComponent<CardDisplay>().card;
        GameManager.players[GameManager.activePlayerIndex].SetPlayer(card.classe, card.artwork);
        GameManager.activePlayerIndex = (GameManager.activePlayerIndex + 1) % GameManager.players.Length;

        if (GameManager.activePlayerIndex == 0)
        {
            SceneController.LoadSceneDestroyingMusic("Game");
        }

        gameObject.SetActive(false);
    }

    private void OnMouseEnter()
    {
        lightEmissor.enabled = true;
    }

    private void OnMouseExit()
    {
        lightEmissor.enabled = false;
    }
}
