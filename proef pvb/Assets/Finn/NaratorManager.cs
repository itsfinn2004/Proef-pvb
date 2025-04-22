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

    public void PlayAudio(int number)
    {
        audiosource.clip = VoiceLines[number];
        audiosource.Play();
    }
}
