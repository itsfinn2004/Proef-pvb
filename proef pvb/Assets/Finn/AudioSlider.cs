using UnityEngine;
using UnityEngine.UI;

public class AudioSlider : MonoBehaviour
{
    public Slider volumeSlider;        
    public AudioSource audioSource;    

    void Start()
    {
        
        if (volumeSlider != null && audioSource != null)
        {
            volumeSlider.value = audioSource.volume;
            volumeSlider.onValueChanged.AddListener(SetVolume);
        }
    }

    public void SetVolume(float volume)
    {
        if (audioSource != null)
        {
            audioSource.volume = volume;
        }
    }
}
