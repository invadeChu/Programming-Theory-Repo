using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * OrangeBox is orange and scaled
 */
public class OrangeBox : BoxThing // Inheritance
{
    public override void SetColor() // Polymorphism - method overriding
    {
        Renderer boxRenderer = GetComponent<Renderer>();
        boxRenderer.material.color = new Color(1f, 0.47f, 0f, 1f);
    }
    private void SetScale() // Abstraction
    {
        Vector3 objectScale = transform.localScale;
        transform.localScale = new Vector3(objectScale.x * sizeScale, objectScale.y * sizeScale, objectScale.z * sizeScale);
    }
    public void Awake()
    {
        SetColor();
        SetScale();
        lifeStart = Time.time;
    }
    public void Update()
    {
        CheckLifeSpan(2); // Polymorphism - method overloading
    }
}
