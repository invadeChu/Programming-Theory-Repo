using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeBox : BoxThing
{
    private float _sizeMultiplier = 1.5f;
    private float _rotateSpeed = -12f;
    public override void SetName()
    {
        _boxName = "Orange Box";
    }

    public override void SetColor()
    {
        _boxColor = "Orange";
        Renderer boxRenderer = GetComponent<Renderer>();
        boxRenderer.material.color = new Color(1f, 0.4705882f, 0f, 1f);
    }

    public void Awake()
    {
        Vector3 objectScale = transform.localScale;
        transform.localScale = new Vector3(objectScale.x * _sizeMultiplier, objectScale.y, objectScale.z);
        SetColor();
    }

    public void Update()
    {
        transform.Rotate(_rotateSpeed * Time.deltaTime, 0f, 0f, Space.World);
    }
}
