using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runScript : MonoBehaviour
{

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("runInt", 1);
        } else
        {
            animator.SetInteger("runInt", 0);
        }


    }
}
