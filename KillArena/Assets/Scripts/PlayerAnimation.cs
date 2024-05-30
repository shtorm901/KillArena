using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator Anim;


    public void Start()
    {
        Anim = GetComponent<Animator>();

    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Anim.SetBool("Press", true);
        }
        else
        {
            Anim.SetBool("Press", false);
        }
    }
}