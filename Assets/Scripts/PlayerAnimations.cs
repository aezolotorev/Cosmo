using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator animator;
    public PlayerProperties playerProperties;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }



    public void AnimationUpdate()
    {
        if (playerProperties.isMoving)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
        if (playerProperties.isJump&&!playerProperties.isGround)
        {
            animator.SetBool("isJumping", true);
        }
        else
            animator.SetBool("isJumping", false);

        if (playerProperties.isGround)
        {
            animator.SetBool("isJumping", false);
        }
        

    }
}
