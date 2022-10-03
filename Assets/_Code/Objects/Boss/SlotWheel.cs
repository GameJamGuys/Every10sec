using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotWheel : MonoBehaviour
{
    public CardSuit slotSuit;
    public Color disColor;
    SlotSuit slot;
    Animator anim;
    Image image;

    void Awake()
    {
        anim = GetComponent<Animator>();
        image = GetComponent<Image>();
    }

    public void Deactive() => image.color = disColor;

    public void SetSuit(CardSuit suit)
    {
        image.color = Color.white;
        Debug.Log(image.color);
        anim.SetTrigger("Roll");
        Debug.Log("Roll");
        StartCoroutine(WaitAndSet(suit));
    }

    IEnumerator WaitAndSet(CardSuit suit)
    {
        slot = GetComponentInChildren<SlotSuit>();
        yield return new WaitForSeconds(0.05f);
        Debug.Log($"Set {suit}");
        slot.SetSuit(suit);
        slotSuit = suit;
    }
    

}
