using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public AudioSource buttonSound;

    public Sprite activeSprite;
    public Sprite inactiveSprite;

    private static bool isMusicActive = true;
    private Image mainImage;

    private AudioSource music;

    private void Awake()
    {
        music = GameObject.Find("MusicSource").GetComponent<AudioSource>();
        mainImage = gameObject.GetComponent<Image>();
        music.mute = !isMusicActive;

        if (music.mute)
            mainImage.sprite = inactiveSprite;
        else
            mainImage.sprite = activeSprite;
    }
    public void Click()
    {
        ToggleMusicVolume();
        SetToNextSprite();
        PlayButtonSound();
    }
    public void ToggleMusicVolume()
    {
        music.mute = !music.mute;
        isMusicActive = !music.mute;
    }

    public void PlayButtonSound()
    {
        buttonSound.Play();
    }

    public void SetToNextSprite()
    {
        mainImage.sprite = isMusicActive ? activeSprite : inactiveSprite;
    }
}
