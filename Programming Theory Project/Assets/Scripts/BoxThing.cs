using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxThing : MonoBehaviour
{
    public Color boxColor;
    public float lifeStart = 0.0f;
    public float lifeSpan = 3.0f;
    public float rotateAngle = 12.0f;
    public float sizeScale = 1.0f;

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
    public virtual void SetColor()
    {
        Debug.Log("Set the box color");
    }
    public virtual void SetRotation()
    {
        Debug.Log("Set the box rotation");
    }
    public virtual void SetScale()
    {
        Debug.Log("Set the box scale");
    }
}
