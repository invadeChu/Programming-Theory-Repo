using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxThing : MonoBehaviour
{
    protected Color boxColor;
    protected float lifeStart;
    protected float lifeSpan = 3.0f;
    protected float rotateAngle = 12.0f;
    protected float sizeScale = 0.5f;

    public void CheckLifeSpan()
    {
        if (lifeStart == 0.0f)
        {
            lifeStart = Time.time;
        }
        float currentLifeTime = Time.time - lifeStart;
        if (currentLifeTime > lifeSpan)
            Destroy(gameObject);
    }
    public void CheckLifeSpan(int overrideLifespan) // Polymorphism - method overloading
    {
        if (lifeStart == 0.0f)
        {
            lifeStart = Time.time;
        }
        float currentLifeTime = Time.time - lifeStart;
        if (currentLifeTime > overrideLifespan)
            Destroy(gameObject);
    }
    public virtual void SetColor()
    {
        Debug.Log("Set the box color");
    }
}
