using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : StaticInstance<BattleManager>
{
    //public 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TryAttack()
    {
        if (SlotManager.Instance.IsAllGood()) return;

        BossLogic.Instance.Attack();
    }


}
