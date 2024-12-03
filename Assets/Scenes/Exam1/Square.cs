using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private float raidus;

    public override float CalculateArea()
    { 

        Debug.Log($"{shapeName} side: ");

        Debug.Log($"{shapeName} area: ");
    }
}
