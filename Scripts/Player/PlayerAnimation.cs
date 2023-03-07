using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerAnimation
{
    public Animator animator;

    public void UpdateAnimatorParameters(float horizontal, float vertical)
    {
        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);
    }

    public void PlayAttackAnimation(bool attackValue)
    {
        UpdateAnimatorParameters(0, 0);
        animator.SetBool("Attack", attackValue);
    }
}
