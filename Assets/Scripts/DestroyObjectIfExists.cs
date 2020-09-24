using UnityEngine;

public class DestroyObjectIfExists : MonoBehaviour
{
    private void Awake()
    {
        gameObject.name = "Music";

        if (GameObject.Find("MusicSource") != null) {
            Destroy(gameObject);
        }
        gameObject.name = "MusicSource";
    }
}
