using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FruitBaseState
{
    public abstract void EnterState(FruitStateManager fruit);
    public abstract void UpdateState(FruitStateManager fruit);
    public abstract void OnCollisionEnter(FruitStateManager fruit, Collision2D collision);
}
