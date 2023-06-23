using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    private PlayerInput playerInput;

    //Input Actions
    private InputAction jumplAction;
    private InputAction movementAction;
    private InputAction runAction;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();

        jumplAction = playerInput.actions["Jump"];
        movementAction = playerInput.actions["Move"];
        runAction = playerInput.actions["Run"];
    }

    public bool IsRunPressed()
    {
        return runAction.triggered;
    }

    public Vector2 GetMovement()
    {
        return movementAction.ReadValue<Vector2>();
    }

    public bool IsJumpPressed()
    {
        return jumplAction.triggered;
    }
}
