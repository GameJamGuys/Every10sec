using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSkill : BaseSkill
{
    public int attackAmount;

    void Start()
    {
        
    }

    public override void UseSkill()
    {
        base.UseSkill();
        BattleManager.Instance.PlayerAttack(attackAmount);
    }
}
