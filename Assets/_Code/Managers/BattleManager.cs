using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : StaticInstance<BattleManager>
{
    public CardHolder cardHolder;

    public bool extra;
    
    void Start()
    {
        DrawCards();
        extra = false;
    }


    public void DrawCards() => cardHolder.FillHand();

    public void PlayerAttack(int amount)
    {
        if (extra) amount *= 2;
        BossLogic.Instance.PlayerAttack(amount);
        extra = false;
    }
        

    public void BossTryAttack()
    {
        if (SlotManager.Instance.IsAllGood())
        {
            Debug.Log("Conditions complete");
            return;
        }

        BossLogic.Instance.Attack();
    }


}
