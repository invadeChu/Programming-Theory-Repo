using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxThing : MonoBehaviour
{
    public string _boxName { get; set; }
    public string _boxColor { get; set; }

    public virtual void SetName()
    {
        Debug.Log("This box is called: " + _boxName);
    }

    public virtual void SetColor()
    {
        Debug.Log("This box's color is: " + _boxColor);
    }
}
