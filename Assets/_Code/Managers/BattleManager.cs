using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : StaticInstance<BattleManager>
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerAttack(int amount) => BossLogic.Instance.PlayerAttack(amount);

    public void BossTryAttack()
    {
        if (SlotManager.Instance.IsAllGood()) return;

        BossLogic.Instance.Attack();
    }


}
