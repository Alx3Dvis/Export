using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))  // Ќажата W (можно заменить на другую клавишу)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
