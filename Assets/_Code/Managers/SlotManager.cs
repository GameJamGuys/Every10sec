using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : StaticInstance<SlotManager>
{
    public CardSuit[] slotSuits;

    void Start()
    {
       
    }

    void Update()
    {
        
    }
}

public enum CardSuit
{
    Diamond,
    Heart,
    Club,
    Spade
}
