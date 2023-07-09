using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAnimation : MonoBehaviour {
    [SerializeField] private Animator anim;

    public void Idle() {
        anim.Play("Root|Idle");
    }

    public void Run() {
        anim.Play("Run");
    }
    
}
