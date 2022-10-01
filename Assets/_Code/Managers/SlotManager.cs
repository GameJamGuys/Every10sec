using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : StaticInstance<SlotManager>
{
    public List<CardSuit> slotSuits;
    List<CardSuit> tempSuits;

    public SlotWheel[] slots;

    public int conditions;

    void Start()
    {
        SetSlots();
    }

    public void CheckSuit(CardSuit suit)
    {
        foreach(CardSuit temp in tempSuits)
        {
            if(temp == suit)
            {
                tempSuits.Remove(temp);
                conditions--;
                return;
            }
        }
    }

    public bool AllGood()
    {
        return conditions == 0;
    }

    public void SetSlots()
    {
        foreach(CardSuit suit in slotSuits)
        {
            int index = slotSuits.IndexOf(suit);
            slots[index].SetSuit(suit);
        }
        tempSuits = slotSuits;
        conditions = 3;
    }
}

public enum CardSuit
{
    Diamond = 0,
    Heart = 1,
    Club = 2,
    Spade = 3
}
