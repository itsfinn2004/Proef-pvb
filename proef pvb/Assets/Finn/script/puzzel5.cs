using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Animations;
public class puzzel5 : MonoBehaviour
{

    public int targetHit = 0 ;
    public int targetsToHit;
    public GameObject fence;
    public Animation openGate;
    private void Awake()
    {
        targetsToHit = GameObject.FindGameObjectsWithTag("target").Length;
    }
    
     public void hittarget()
    {
        if (targetHit >= targetsToHit) // als je alle targets geraakt heb in game dan opent de gate
        {
            openGate.Play();
            Debug.Log("all target hit");
        }
    }


}
