using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * GreenBox is green with half scale and rotates on z axis
 */
public class GreenBox : BoxThing
{
    public override void SetColor()
    {
        Renderer boxRenderer = GetComponent<Renderer>();
        boxRenderer.material.color = new Color(0f, 0.9f, 0f, 1f);
    }
    public override void SetRotation()
    {
        transform.Rotate(0f, 0f, rotateAngle * Time.deltaTime, Space.World);
    }
    public override void SetScale()
    {
        Vector3 objectScale = transform.localScale;
        transform.localScale = new Vector3(objectScale.x * sizeScale / 2, 
            objectScale.y * sizeScale / 2, objectScale.z * sizeScale / 2);
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
