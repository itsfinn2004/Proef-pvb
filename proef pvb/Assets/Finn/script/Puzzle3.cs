using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Animations;

public class Puzzle3 : MonoBehaviour
{
    public Animation opengate;
    public ButtonColor[] buttons;

    public void CheckColors()
    {
        foreach (ButtonColor button in buttons)
        {
            if (button.currentCube == null) //als er geen cubus op de button ligt
            {
                Debug.Log("Button missing a cube!");
                return;
            }

            CubeColor cubeColor = button.currentCube.GetComponent<CubeColor>();
            if (cubeColor == null || cubeColor.cubeColor != button.buttonColor) // hier vergelijkt hij de kleuren van de button en de cube
            {
                Debug.Log("Wrong color on a button!");
               
                return;
            }
        }

        Debug.Log("All colors correct!");
        opengate.Play();
        
    }
}
         
    

