using UnityEngine;

public class ToggleObjectOnClickKey : MonoBehaviour
{
    public KeyCode key;
    public GameObject GO;

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            GO.SetActive(!GO.activeSelf);
        }
    }
}
