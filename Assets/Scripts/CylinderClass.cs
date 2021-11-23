using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderClass : ShapeBehaviour
{
    [SerializeField] private float rotationSpeed;
    protected override void DoActionOnDown()
    {
        ChangeColor();
    }
    protected override void DoActionOnOver()
    {
        Rotate();
    }
    private void Rotate()
    {
        transform.Rotate(1 * rotationSpeed * Time.deltaTime, 0, 0);
    }
}
