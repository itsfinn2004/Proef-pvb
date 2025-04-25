using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bulletPrefab;     
    public Transform shootPoint;         
      

  

    public void Shoot()
    {
        // Instantiate the bullet at the shoot point's position and rotation
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);

      
    }
}


