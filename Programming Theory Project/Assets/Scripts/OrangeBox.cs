using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * OrangeBox is orange with a 1:1:1 scale and rotates on x axis
 */
public class OrangeBox : BoxThing
{
    public override void SetColor()
    {
        Renderer boxRenderer = GetComponent<Renderer>();
        boxRenderer.material.color = new Color(1f, 0.47f, 0f, 1f);
    }
    public override void SetRotation()
    {
        transform.Rotate(rotateAngle * Time.deltaTime, 0f, 0f, Space.World);
    }
    public override void SetScale()
    {
        Vector3 objectScale = transform.localScale;
        transform.localScale = new Vector3(objectScale.x * sizeScale, objectScale.y, objectScale.z);
    }
        public void Awake()
    {
        SetColor();
        SetScale();
        lifeStart = Time.time;
    }
        public void Update()
    {
        SetRotation();
        CheckLifeSpan();
    }
}
