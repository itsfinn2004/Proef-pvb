using UnityEngine;

public class ButtonColor : MonoBehaviour
{
        Puzzle3 p3;
        public Color buttonColor; 
        public GameObject currentCube; 


    private void Start()    
    {
        p3 = GameObject.Find("Puzzlemaster(test)").GetComponent<Puzzle3>();
        Renderer renderer = gameObject.GetComponent<Renderer>();
        buttonColor = renderer.material.color;
    }

  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            currentCube = collision.gameObject;
            p3.CheckColors();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            if (currentCube == collision.gameObject)
                currentCube = null;
        }
    }

}
