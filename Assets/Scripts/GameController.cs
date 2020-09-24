using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    /// <summary>
    /// Setar a quantidade de jogadores a jogar
    /// </summary>
    /// <param name="dropdown"> O dropdown que contém a opção selecionada</param>
    public void SetPlayersQuantity(Dropdown dropdown)
    {
        print("Quantidade de jogadores: " + (dropdown.value + 2));
        GameManager.players = new Player[dropdown.value +2];
        GameManager.activePlayerIndex = 0;
    }
    /// <summary>
    /// Selecionar o personagem para o jogador em questãono OnMouseUp
    /// </summary>
    private void OnMouseUp()
    {
        print("clicou");
        GameManager.players[GameManager.activePlayerIndex] = new Player(GetComponent<CharacterCard>());
        GameManager.activePlayerIndex = (GameManager.activePlayerIndex + 1) % GameManager.players.Length;
        gameObject.SetActive(false);
    }
}
