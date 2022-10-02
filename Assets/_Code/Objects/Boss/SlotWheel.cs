using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotWheel : MonoBehaviour
{
    public CardSuit slotSuit;
    SlotSuit slot;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void SetSuit(CardSuit suit) => StartCoroutine(WaitAndSet(suit));

    IEnumerator WaitAndSet(CardSuit suit)
    {
        anim.SetTrigger("Roll");
        slot = GetComponentInChildren<SlotSuit>();
        yield return new WaitForSeconds(0.25f);
        Debug.Log($"Set {suit}");
        slot.SetSuit(suit);
        slotSuit = suit;
    }
    

}
