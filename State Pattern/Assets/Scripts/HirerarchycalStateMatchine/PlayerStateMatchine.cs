using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMatchine : MonoBehaviour
{
    //Steate Variables
    PlayerBaseState _currentState;
    PlayerStateFactory _steates;

    //Getters and Setters
    public PlayerBaseState CurrentState { get { return _currentState; } set { _currentState = value; } }

    void Awake()
    {
        //Setup States
        _steates = new PlayerStateFactory(this);
        _currentState = _steates.Grounded();
        _currentState.EnterState();
    }

    void Update()
    {

    }
}
