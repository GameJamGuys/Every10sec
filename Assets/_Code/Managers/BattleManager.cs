using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : StaticInstance<BattleManager>
{
    public int bossHealth; 

    // Start is called before the first frame update
    void Start()
    {
        BossLogic.Instance.health.maxHealth = bossHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerAttack(int amount)
    {
        bossHealth = Mathf.Clamp(bossHealth - amount, 0, BossLogic.Instance.health.maxHealth);
        BossLogic.Instance.ChangeHP(bossHealth);
    }

    public void BossTryAttack()
    {
        if (SlotManager.Instance.IsAllGood()) return;

        BossLogic.Instance.Attack();
    }


}
