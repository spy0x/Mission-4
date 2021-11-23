using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CapsuleClass : ShapeBehaviour
{
    private Animator anim;
    protected override void Start()
    {
        base.Start();
        anim = GetComponent<Animator>();
    }
    protected override void DoActionOnDown()
    {
        // EMPTY BECAUSE DONT WANT TO DO ANYTHING 
    }
    protected override void DoActionOnOver()
    {
        anim.SetTrigger("Over");
    }
}
