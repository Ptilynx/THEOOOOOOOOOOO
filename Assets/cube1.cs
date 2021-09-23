using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube1 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.I))
        {
            animator.Play("idle");
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            animator.Play("" +
                "punch");
        }
    }
}
