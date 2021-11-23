using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderClass : ShapeBehaviour // INHERITANCE
{
    [SerializeField] private float rotationSpeed = 1;
    protected override void DoActionOnDown() // POLYMORPHISM
    {
        ChangeColor(); // ABSTRACTION
    }
    protected override void DoActionOnOver() // POLYMORPHISM
    {
        Rotate(); // ABSTRACTION
    }
    private void Rotate()
    {
        transform.Rotate(1 * rotationSpeed * Time.deltaTime, 0, 0);
    }
}
