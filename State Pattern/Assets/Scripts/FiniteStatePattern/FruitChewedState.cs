using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitChewedState : FruitBaseState
{
    float ligeTime = 3.0f;

    public override void EnterState(FruitStateManager fruit)
    {
        fruit.transform.localScale = new Vector2(1, 0.25f);
    }

    public override void UpdateState(FruitStateManager fruit)
    {
        if (ligeTime > 0)
        {
            ligeTime -= Time.deltaTime;
        }
        else
        {
            fruit.DestroyFruit();
        }
    }

    public override void OnCollisionEnter(FruitStateManager fruit, Collision2D collision)
    {
        
    }
}
