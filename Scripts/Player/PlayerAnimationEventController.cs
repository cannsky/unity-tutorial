using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationEventController : MonoBehaviour
{
    public void ResetAttackStatus()
    {
        Player.Instance.playerAttack.isAttacking = false;
        Player.Instance.playerAnimation.PlayAttackAnimation(false);
    }
}
