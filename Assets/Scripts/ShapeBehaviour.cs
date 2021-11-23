
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShapeBehaviour : MonoBehaviour
{
    [ColorUsage(false, false)]
    [SerializeField] protected Color color;
    [SerializeField] private TextMeshProUGUI totalClicks;
    private int shapeClicks = 0;
    protected MeshRenderer meshRenderer;
    private static int allShapesTotalClicks;
    public static int AllShapesTotalClicks { get { return allShapesTotalClicks; } set { allShapesTotalClicks = value; } }
    protected virtual void Start()
    {
        UpdateUI();
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
        UpdateUI();
    }
    protected void ChangeColor()
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
