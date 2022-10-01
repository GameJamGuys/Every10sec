using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : StaticInstance<SlotManager>
{
    public List<CardSuit> slotSuits;
    public SlotWheel[] slots;

    void Start()
    {
        SetSlots();
    }

    void Update()
    {
        
    }

    public void SetSlots()
    {
        foreach(CardSuit suit in slotSuits)
        {
            int index = slotSuits.IndexOf(suit);
            slots[index].SetSuit(suit);
        }
    }
}

public enum CardSuit
{
    Diamond = 0,
    Heart = 1,
    Club = 2,
    Spade = 3
}
