using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeBehaviour : MonoBehaviour
{
    [ColorUsage(false, false)]
    [SerializeField] protected Color color;
    private int shapeClicks = 0;
    protected MeshRenderer meshRenderer;
    private static int allShapesTotalClicks;
    public static int AllShapesTotalClicks { get { return allShapesTotalClicks; } set { allShapesTotalClicks = value; } }
    protected virtual void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = color;
    }
    private void OnMouseDown()
    {
        DoActionOnDown();
        AddClickCounts();
    }
    private void OnMouseOver()
    {
        DoActionOnOver();
    }
    private void AddClickCounts()
    {
        allShapesTotalClicks++;
        shapeClicks++;
    }
    protected virtual void DoActionOnDown()
    {
        Debug.Log("Override this method please");
    }
    protected virtual void DoActionOnOver()
    {
        Debug.Log("Override this method please");
    }
}
