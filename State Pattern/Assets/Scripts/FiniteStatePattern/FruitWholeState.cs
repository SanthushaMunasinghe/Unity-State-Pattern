using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitWholeState : FruitBaseState
{
    private float lifeTime = 5.0f;

    public override void EnterState(FruitStateManager fruit)
    {
        fruit.rb.gravityScale = 1;
    }

    public override void UpdateState(FruitStateManager fruit)
    {
        if (lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
        }
        else
        {
            fruit.SwitchState(fruit.fruitRottenState);
        }
    }

    public override void OnCollisionEnter(FruitStateManager fruit, Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("Player Health++");
            fruit.SwitchState(fruit.fruitChewed);
        }
    }
}
