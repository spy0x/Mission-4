using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class CubeClass : ShapeBehaviour
{
    [SerializeField] private AudioSource audioSource;
    protected override void DoActionOnDown()
    {
        audioSource.Play();
    }
    protected override void DoActionOnOver()
    {
        meshRenderer.material.color = Random.ColorHSV();
    }
}
