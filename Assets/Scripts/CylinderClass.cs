using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderClass : ShapeBehaviour
{
    [SerializeField] private float rotationSpeed;
    protected override void DoActionOnDown()
    {
        meshRenderer.material.color = Random.ColorHSV();
    }
    protected override void DoActionOnOver()
    {
        transform.Rotate(1 * rotationSpeed * Time.deltaTime, 0, 0);
    }
}
