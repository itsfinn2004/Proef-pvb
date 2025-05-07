using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class NaratorTrigger : MonoBehaviour
{
   public NaratorManager nm;
    public int NumberToPlay;
    private void Awake()
    {
        nm = GameObject.Find("audioManager").GetComponent<NaratorManager>(); 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("player colided");
            nm.PlayAudio(NumberToPlay);
            this.gameObject.SetActive(false);
        }
    }
}
