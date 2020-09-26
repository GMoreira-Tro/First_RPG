using UnityEngine;
using UnityEngine.UI;

public class PlayersDropdown : MonoBehaviour
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
}
