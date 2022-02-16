using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBox : BoxThing
{
    private float _sizeMultiplier = 0.5f;
    private float _rotateSpeed = 24f;
    public override void SetName()
    {
        _boxName = "Green Box";
    }

    public override void SetColor()
    {
        _boxColor = "Green";
        Renderer boxRenderer = GetComponent<Renderer>();
        boxRenderer.material.color = new Color(0f, 0.9f, 0f, 1f);
    }

    public void Awake()
    {
        Vector3 objectScale = transform.localScale;
        transform.localScale = new Vector3(objectScale.x * _sizeMultiplier, objectScale.y * _sizeMultiplier, objectScale.z * _sizeMultiplier);
        SetColor();
    }

    public void Update()
    {
        transform.Rotate(0f, _rotateSpeed * Time.deltaTime, 0f, Space.World);
    }
}
