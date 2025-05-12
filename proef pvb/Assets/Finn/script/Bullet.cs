using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float lifeTime = 5f;
    puzzel5 p5;
    

    void Start()
    {
            p5 = GameObject.Find("Puzzlemaster(test)").GetComponent<puzzel5>(); //pakt de puzzel 5 scritp
    
        
            GetComponent<Rigidbody>().linearVelocity = transform.forward * speed; // geeft de bullet velocity zodat het naar voren gaat
        
        Destroy(gameObject, lifeTime); 
    }
    private void OnCollisionEnter(Collision collision) //als de kogel een target raakt krijgt de puzzel 5 scirpt targethit +1 count
    {
        if(collision.gameObject.CompareTag("target"))
        {
            Destroy(collision.gameObject);
            p5.targetHit++;
            p5.hittarget();

            
        }
    }


}
