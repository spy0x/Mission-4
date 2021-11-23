using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CapsuleClass : ShapeBehaviour // INHERITANCE
{
    private Animator anim;
    protected override void Start() // POLYMORPHISM
    {
        base.Start();
        anim = GetComponent<Animator>();
    }
    protected override void DoActionOnDown() // POLYMORPHISM
    {
        // EMPTY BECAUSE DONT WANT TO DO ANYTHING 
    }
    protected override void DoActionOnOver() // POLYMORPHISM
    {
        TriggerAnimation(); // ABSTRACTION
    }

    private void TriggerAnimation()
    {
        anim.SetTrigger("Over");
    }
}
