using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotSuit : MonoBehaviour
{
    public CardSuit suit;

    public GameObject[] allSuits;

    private void Start()
    {
       // SetSuit(suit);
    }

    public void SetSuit(CardSuit suit)
    {
        transform.DeactiveChildren();
        this.suit = suit;
        allSuits[((int)suit)].SetActive(true);
    }
}
