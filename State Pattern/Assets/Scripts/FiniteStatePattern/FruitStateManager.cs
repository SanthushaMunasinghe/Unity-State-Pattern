using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitStateManager : MonoBehaviour
{
    FruitBaseState currentState;

    public FruitGrowingState fruitGrowing = new FruitGrowingState();
    public FruitWholeState fruitWhole = new FruitWholeState();
    public FruitChewedState fruitChewed = new FruitChewedState();
    public FruitRottenState fruitRottenState = new FruitRottenState();

    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        currentState = fruitGrowing;

        currentState.EnterState(this);
    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        currentState.OnCollisionEnter(this, collision);
    }

    public void DestroyFruit()
    {
        Destroy(gameObject);
    }

    public void SwitchState(FruitBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
