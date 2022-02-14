using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxThing : MonoBehaviour
{
    private string _boxName;
    private string _boxColor;

    public void DisplayName()
    {
        Debug.Log("This box is called: " + _boxName);
    }

    public void DisplayColor()
    {
        Debug.Log("This box's color is: " + _boxColor);
    }
}
