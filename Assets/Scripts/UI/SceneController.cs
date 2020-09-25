using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Classe que conterá as principais funções de UI
/// </summary>
public class SceneController : MonoBehaviour
{
    /// <summary>
    /// Um simples carregamento de cena
    /// </summary>
    /// <param name="name"></param>
    public static void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    /// <summary>
    /// Carregar uma cena colocando a fonte da música na pilha do DontDestroyOnLoad
    /// </summary>
    /// <param name="name"></param>
    public static void LoadSceneWithoutDestroyMusic(string name)
    {
        DontDestroyOnLoad(GameObject.Find("MusicSource"));
        SceneManager.LoadScene(name);
    }
    /// <summary>
    /// Carregar uma cena destruindo a fonte da música
    /// </summary>
    /// <param name="name"></param>
    public static void LoadSceneDestroyingMusic(string name)
    {
        Destroy(GameObject.Find("MusicSource"));
        SceneManager.LoadScene(name);
    }
    /// <summary>
    /// Fechando a aplicação
    /// </summary>
    public static void QuitGame()
    {
        Application.Quit();
    }
}
