using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeBehaviour : MonoBehaviour
{
    [SerializeField] private Color32 color;
    private int shapeClicks = 0;
    private static int allShapesTotalClicks;
    public static int AllShapesTotalClicks { get { return allShapesTotalClicks; } set { allShapesTotalClicks = value; } }
    private void Start()
    {
        GetComponent<MeshRenderer>().material.color = color;
    }
    private void OnMouseDown()
    {
        DoAction();
        AddClickCount();
    }

    private void AddClickCount()
    {
        allShapesTotalClicks++;
        shapeClicks++;
    }

    protected virtual void DoAction()
    {
        Debug.Log("Override this method please");
    }
}
