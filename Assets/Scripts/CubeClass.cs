using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class CubeClass : ShapeBehaviour // INHERITANCE
{
    [SerializeField] private AudioSource audioSource;
    protected override void DoActionOnDown() // POLYMORPHISM
    {
        PlaySound(); // ABSTRACTION
    }
    protected override void DoActionOnOver() // POLYMORPHISM
    {
        ChangeColor();
    }
    private void PlaySound()
    {
        audioSource.Play();
    }
}
