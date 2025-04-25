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
            p5 = GameObject.Find("Puzzlemaster(test)").GetComponent<puzzel5>();
    
        
            GetComponent<Rigidbody>().linearVelocity = transform.forward * speed;
        
        Destroy(gameObject, lifeTime); 
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("target"))
        {
            Destroy(collision.gameObject);
            p5.targetHit++;
            p5.hittarget();

            // hier de code voor wat er dan moet gebeuren(een brug valt en je kan verer ofzo)
        }
    }


}
