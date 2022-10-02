using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDrag : MonoBehaviour
{

    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private GameObject hand;
    private float interpolateAmount;

    public void Start()
    {
        //ToSplineHand();
    }

    public void cardDragging()
    {
        while (hand.transform.childCount != 5)
        {
            Instantiate(cardPrefab, hand.transform);
        }
    }
}
