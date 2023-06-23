using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGrowingState : FruitBaseState
{
    Vector3 startFruitSize = new Vector3(0.25f, 0.25f, 0.25f);
    Vector3 growingScalar = new Vector3(0.1f, 0.1f, 0.1f);

    public override void EnterState(FruitStateManager fruit)
    {
        fruit.transform.localScale = startFruitSize;
    }

    public override void UpdateState(FruitStateManager fruit)
    {
        if (fruit.transform.localScale.x < 1)
        {
            fruit.transform.localScale += growingScalar * Time.deltaTime;
        }
        else
        {
            fruit.SwitchState(fruit.fruitWhole);
        }
    }

    public override void OnCollisionEnter(FruitStateManager fruit, Collision2D collision)
    {

    }
}
