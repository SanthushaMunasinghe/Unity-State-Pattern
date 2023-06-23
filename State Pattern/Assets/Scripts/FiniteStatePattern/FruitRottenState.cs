using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitRottenState : FruitBaseState
{
    private Color currentColor;
    private Color rottenColor = new Color(0, 0, 0);

    public float duration = 1.0f;
    private float t = 0.0f;

    public override void EnterState(FruitStateManager fruit)
    {
        currentColor = fruit.GetComponent<SpriteRenderer>().color;
    }

    public override void UpdateState(FruitStateManager fruit)
    {
        t += Time.deltaTime / duration;

        Color lerpedColor = Color.Lerp(currentColor, rottenColor, t);

        SpriteRenderer renderer = fruit.GetComponent<SpriteRenderer>();
        renderer.material.color = lerpedColor;
    }

    public override void OnCollisionEnter(FruitStateManager fruit, Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("Player Health--");
            fruit.SwitchState(fruit.fruitChewed);
        }
    }
}
