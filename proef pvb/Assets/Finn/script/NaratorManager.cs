using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class NaratorManager : MonoBehaviour
{
    public AudioClip[] VoiceLines;
    public AudioSource audiosource;
    

    private void Start()
    {
        audiosource = GameObject.Find("audioManager").GetComponent<AudioSource>();

    }

    public void PlayAudio(int number) //speelt audio af op wat de NaratorTrigger hem geeft qua nummer
    {
        audiosource.clip = VoiceLines[number];
        audiosource.Play();
    }
}
