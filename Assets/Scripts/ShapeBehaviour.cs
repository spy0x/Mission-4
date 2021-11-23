
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShapeBehaviour : MonoBehaviour
{
    [ColorUsage(false, false)]
    [SerializeField] private Color color;
    [SerializeField] private TextMeshProUGUI totalClicks;
    [SerializeField] private TextMeshProUGUI shapeClicksTxt;
    private int shapeClicks = 0;
    protected MeshRenderer meshRenderer;
    private static int allShapesTotalClicks;
    public static int AllShapesTotalClicks { get { return allShapesTotalClicks; } set { allShapesTotalClicks = value; } } // ENCAPSULATION
    protected virtual void Start()
    {
        UpdateUI();
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = color;
    }
    private void OnMouseDown()
    {
        DoActionOnDown(); 
        AddClickCounts(); // ABSTRACTION
    }
    private void OnMouseOver()
    {
        DoActionOnOver();
    }
    private void AddClickCounts()
    {
        allShapesTotalClicks++;
        shapeClicks++;
        UpdateUI(); // ABSTRACTION
    }
    protected void ChangeColor() // POLYMORPHISM (Method Overloading)
    {
        meshRenderer.material.color = Random.ColorHSV();
    }
    protected void ChangeColor(Color color)
    {
        meshRenderer.material.color = color;
    }
    private void UpdateUI()
    {
        totalClicks.text = $"Total Clicks: {allShapesTotalClicks}";
        shapeClicksTxt.text = $"Clicks: {shapeClicks}";
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
