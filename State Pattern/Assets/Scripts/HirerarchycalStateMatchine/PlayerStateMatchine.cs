using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMatchine : MonoBehaviour
{
    //Steate Variables
    PlayerBaseState _currentState;
    PlayerStateFactory _steates;

    //Player Action
    private bool _isJumpPressed;

    //Getters and Setters
    public PlayerBaseState CurrentState { get { return _currentState; } set { _currentState = value; } }
    public bool IsJumpPressed { get { return _isJumpPressed; } set { _isJumpPressed = value; } }

    [SerializeField] private PlayerInputManager playerInputManager;

    void Awake()
    {
        //Setup States
        _steates = new PlayerStateFactory(this);
        _currentState = _steates.Grounded();
        _currentState.EnterState();
    }

    void Update()
    {
        //Check Inputs
        CheckJumpPressed();

        //State
        _currentState.UpdateState();
    }

    private void CheckJumpPressed()
    {
        if (playerInputManager.IsJumpPressed())
        {
            _isJumpPressed = true;
        }
    }
}
