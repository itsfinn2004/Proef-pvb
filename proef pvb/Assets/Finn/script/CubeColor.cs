using UnityEngine;

public class CubeColor : MonoBehaviour
{
    public Color cubeColor;

    private void Start()
    {
        Renderer renderer = gameObject.GetComponent<Renderer>();
        cubeColor = renderer.material.color; 
    }
}
