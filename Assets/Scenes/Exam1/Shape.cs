using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;

    public void Init(string A)
    {


    }

    public abstract float CalculateArea();

    public void Resize()
    {
        Debug.Log($"Resizing Shape...");

        Debug.Log($"{shapeName} is resized...");
     
    }

    public void Draw()
    {
        Debug.Log($"Drawing {shapeName}");
    }


}
