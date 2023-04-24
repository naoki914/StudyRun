using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
    public static InputManager Instance { get; private set; }

    public event EventHandler OnLeftMovement;
    public event EventHandler OnRightMovement;


    private GameInputActions gameInputActions;

    private void Awake() {
        Debug.Log("InputManager Loaded");
        Instance = this;
        gameInputActions = new GameInputActions();
        gameInputActions.Player.Enable();

        gameInputActions.Player.Left.performed += OnLeft_performed;
        gameInputActions.Player.Right.performed += OnRight_performed;

    }

    private void OnLeft_performed(UnityEngine.InputSystem.InputAction.CallbackContext context) {
        Debug.Log("[A] Left");
        OnLeftMovement?.Invoke(this, EventArgs.Empty);
    }
    private void OnRight_performed(UnityEngine.InputSystem.InputAction.CallbackContext context) {
        Debug.Log("[D] Right");
        OnRightMovement?.Invoke(this, EventArgs.Empty);
    }
}
