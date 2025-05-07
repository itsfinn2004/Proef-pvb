using UnityEngine;

public class LookAtCam : MonoBehaviour
{
   
    
    [SerializeField] Transform transformToFollow;

    const float FOLLOW_SPEED = 5;

   

    private void Awake()
    {
        
    }

    void FixedUpdate()
    {
        transform.LookAt(Camera.main.transform, Vector3.up); 
        transform.Rotate(0f, 180f, 0f); 
        var newPosition = transform.position;
        var followPosition = transformToFollow.position;
        newPosition.x = Mathf.Lerp(newPosition.x, followPosition.x, FOLLOW_SPEED * Time.deltaTime);
        newPosition.y = Mathf.Lerp(newPosition.y, followPosition.y, FOLLOW_SPEED * Time.deltaTime);
        newPosition.z = Mathf.Lerp(newPosition.z, followPosition.z, FOLLOW_SPEED * Time.deltaTime);

        transform.position = newPosition;
    }
}


