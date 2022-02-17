using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * GreenBox is green and rotates on z axis
 */
public class GreenBox : BoxThing // Inheritance
{
    public override void SetColor() // Polymorphism - method overriding
    {
        Renderer boxRenderer = GetComponent<Renderer>();
        boxRenderer.material.color = new Color(0f, 0.9f, 0f, 1f);
    }
    private void SetRotation() // Abstraction
    {
        transform.Rotate(0f, 0f, rotateAngle * Time.deltaTime, Space.World);
    }
    public void Awake()
    {
        SetColor();
        lifeStart = Time.time;
    }
    public void Update()
    {
        SetRotation();
        CheckLifeSpan();
    }
}
