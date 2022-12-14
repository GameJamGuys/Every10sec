using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCard : MonoBehaviour
{
    public CardSuit suit;
    public SlotSuit[] suitSlots;
    public CardSkill cardSkill;
    // Start is called before the first frame update
    void Start()
    {
        SetRandomSuit();
        RandomSet();
    }

    public bool CanUse() => cardSkill.skill.CanUse();

    public void UseCard()
    {
        cardSkill.skill.UseSkill();
        BattleManager.Instance.extra = SlotManager.Instance.CheckSuit(suit);
        Destroy(gameObject);
    }

    public void RandomSet()
    {
        cardSkill.RandomSkill();
    }

    public void SetRandomSuit()
    {
        int random = Random.Range(0, 4);
        suit = (CardSuit)random;
        SetSuit();
    }

    void SetSuit()
    {
        foreach(SlotSuit slotSuit in suitSlots)
        {
            slotSuit.SetSuit(suit);
        }
    }
}
