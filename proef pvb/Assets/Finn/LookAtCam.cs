using UnityEngine;

public class LookAtCam : MonoBehaviour
{
   
    
    [SerializeField] Transform transformToFollow;

    const float speed = 5;

   

    private void Awake()
    {
        
    }

    void FixedUpdate() // als je deze script op een object zet volg die object je op een distance van waar je de transformToFollow hebt gezet in de game
    {
        transform.LookAt(Camera.main.transform, Vector3.up); 
        transform.Rotate(0f, 180f, 0f); 
        var newPosition = transform.position;
        var followPosition = transformToFollow.position;
        newPosition.x = Mathf.Lerp(newPosition.x, followPosition.x, speed * Time.deltaTime);
        newPosition.y = Mathf.Lerp(newPosition.y, followPosition.y, speed * Time.deltaTime);
        newPosition.z = Mathf.Lerp(newPosition.z, followPosition.z, speed * Time.deltaTime);

        transform.position = newPosition;
    }
}


