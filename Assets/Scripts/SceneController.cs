using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void LoadSceneWithoutDestroyMusic(string name)
    {
        DontDestroyOnLoad(GameObject.Find("MusicSource"));
        SceneManager.LoadScene(name);
    }
    public void LoadSceneDestroyingMusic(string name)
    {
        Destroy(GameObject.Find("MusicSource"));
        SceneManager.LoadScene(name);
    }
}
