using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : StaticInstance<BattleManager>
{
    public CardHolder cardHolder;
    
    void Start()
    {
        DrawCards();
    }


    public void DrawCards() => cardHolder.FillHand();

    public void PlayerAttack(int amount) => BossLogic.Instance.PlayerAttack(amount);

    public void BossTryAttack()
    {
        if (SlotManager.Instance.IsAllGood()) return;

        BossLogic.Instance.Attack();
    }


}
