using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static PlayerInput playerInput;

    private InputAction mouse_touch;

    public static bool isLeftMousePressed;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();

        mouse_touch = playerInput.actions["MouseTouch"];
    }

    private void Update()
    {
        isLeftMousePressed = mouse_touch.IsPressed();
    }
}
