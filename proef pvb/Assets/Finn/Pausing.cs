using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class Pausing : MonoBehaviour
{
    private InputAction menuButtonAction;
    public GameObject pauseMenu;

    void OnEnable() //deze script zorgt ervoor dat als je op de menu knop klikt op je oculus controller dat er dan een pauze menu komt
    {
        menuButtonAction = new InputAction(
            name: "MenuButton",
            type: InputActionType.Button,
            binding: "<XRController>{LeftHand}/menuButton"
        );

        menuButtonAction.performed += OnMenuButtonPressed;
        menuButtonAction.Enable();
    }

    void OnDisable()
    {
        menuButtonAction.performed -= OnMenuButtonPressed;
        menuButtonAction.Disable();
    }

    private void OnMenuButtonPressed(InputAction.CallbackContext context)
    {
        pauseMenu.SetActive(true);
    }
    public void MenuGone()
    {
        pauseMenu.SetActive(false);
    }
}
