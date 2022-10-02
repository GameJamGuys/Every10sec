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

    public void ResetSlots()
    {
        for (int i = 0; i < 3; i++)
        {
            slotSuits.RemoveAt(0);
            int random = Random.Range(0, 4);
            CardSuit newSuit = (CardSuit)random;
            slotSuits.Add(newSuit);
        }

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
        StartCoroutine(SetDelay());
    }

    IEnumerator SetDelay()
    {
        foreach (CardSuit suit in slotSuits)
        {
            int index = slotSuits.IndexOf(suit);
            slots[index].SetSuit(suit);
            yield return new WaitForSeconds(0.1f);
        }
        tempSuits = slotSuits;
    }

}

public enum CardSuit
{
    Diamond = 0,
    Heart = 1,
    Club = 2,
    Spade = 3
}
