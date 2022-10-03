using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : StaticInstance<SlotManager>
{
    public List<CardSuit> slotSuits;
    CardSuit[] tempSuits;

    public SlotWheel[] slots;

    public int conditions;

    void Start()
    {
        SetSlots();
    }

    public void ResetSlots()
    {
        slotSuits = new List<CardSuit>();
        
        for (int i = 0; i < 3; i++)
        {
            int random = Random.Range(0, 4);
            CardSuit newSuit = (CardSuit)random;
            slotSuits.Add(newSuit);
        }
        
        SetSlots();
    }

    public void CheckSuit(CardSuit suit)
    {
        foreach(CardSuit temp in slotSuits)
        {
            if(temp == suit)
            {
                slotSuits.Remove(temp);
                conditions--;

                foreach(SlotWheel slot in slots)
                {
                    if(slot.slotSuit == suit)
                    {
                        slot.Deactive();
                        return;
                    }
                }
                return;
            }
        }
    }

    public bool IsAllGood()
    {
        return conditions == 0;
    }

    public void SetSlots()
    {
        conditions = 3;
        tempSuits = slotSuits.ToArray();
        StartCoroutine(SetDelay());
    }

    IEnumerator SetDelay()
    {
        for(int i = 0; i < 3; i++)
        {
            slots[i].SetSuit(tempSuits[i]);
            yield return new WaitForSeconds(0.05f);
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
