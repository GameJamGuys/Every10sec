using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kerioth.Stuff;

public class SlotWheel : MonoBehaviour
{
    public CardSuit slotSuit;
    SlotSuit slot;

    void Start()
    {
        slot = GetComponentInChildren<SlotSuit>();
    }

    public void SetSuit(CardSuit suit)
    {
        slot = GetComponentInChildren<SlotSuit>();
        slot.SetSuit(suit);
        slotSuit = suit;
    }
    

}
