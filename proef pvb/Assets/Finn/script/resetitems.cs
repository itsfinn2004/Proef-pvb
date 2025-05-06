using UnityEngine;

public class resetitems : MonoBehaviour
{
    public GameObject[] boxes; 
  [SerializeField]  private Vector3[] originalPositions;
   [SerializeField] private Rigidbody[] rigidbodies;

    void Start()
    {
      
        originalPositions = new Vector3[boxes.Length];
        rigidbodies = new Rigidbody[boxes.Length];

        for (int i = 0; i < boxes.Length; i++)
        {
            originalPositions[i] = boxes[i].transform.position;
            rigidbodies[i] = boxes[i].GetComponent<Rigidbody>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ResetBoxes();
        }
    }

   public void ResetBoxes()
    {
   
        for (int i = 0; i < boxes.Length; i++)
        {
         
            boxes[i].transform.position = originalPositions[i];
            rigidbodies[i].linearVelocity = Vector3.zero;
            rigidbodies[i].angularVelocity = Vector3.zero;
           
        }
    }

}
