using UnityEngine;

public class DestroyObjectIfExists : MonoBehaviour
{
    public string objectName;
    private void Awake()
    {
        gameObject.name = "";

        if (GameObject.Find(objectName) != null) {
            Destroy(gameObject);
        }
        gameObject.name = objectName;
    }
}
