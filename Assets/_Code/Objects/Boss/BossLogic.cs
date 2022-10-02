using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLogic : StaticInstance<BossLogic>
{
    public int bossHealth;
    public int bossAttack;
    public HealthBar health;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        health.maxHealth = bossHealth;
    }

    public void PlayerAttack(int amount)
    {
        if (PlayerLogic.Instance.curse) amount = amount / 2;
        bossHealth = Mathf.Clamp(bossHealth - amount, 0, health.maxHealth);
        ChangeHP(bossHealth);
    }

    public void ChangeHP(int amount)
    {
        health.Set(amount);
    }

    public void Attack()
    {
        int attackType = Random.Range(1, 4);
        Debug.Log($"Attack type {attackType}");
        switch (attackType)
        {
            case 1:
                anim.SetTrigger("LAttack");
                PlayerLogic.Instance.RecieveAttack(BossAttackType.Left);
                break;
            case 2:
                anim.SetTrigger("RAttack");
                PlayerLogic.Instance.RecieveAttack(BossAttackType.Right);
                break;
            case 3:
                anim.SetTrigger("BAttack");
                PlayerLogic.Instance.RecieveAttack(BossAttackType.Both);
                break;
            default:
                break;
        }
    }
}

public enum BossAttackType
{
    Left, Right, Both
}
