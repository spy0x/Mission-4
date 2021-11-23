using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class CubeClass : ShapeBehaviour
{
    [SerializeField] private AudioSource audioSource;
    protected override void DoActionOnDown()
    {
        PlaySound();
    }
    protected override void DoActionOnOver()
    {
        ChangeColor();
    }
    private void PlaySound()
    {
        audioSource.Play();
    }
}
