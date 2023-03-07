using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack
{
    public bool isAttacking;

    public void OnUpdate()
    {
        if (Player.Instance.playerInputs.attackInput == true && !isAttacking)
        {
            Player.Instance.playerAnimation.PlayAttackAnimation(true);
            isAttacking = true;
        }
    }
}
