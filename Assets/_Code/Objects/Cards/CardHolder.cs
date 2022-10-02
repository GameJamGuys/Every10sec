using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHolder : MonoBehaviour
{
    public GameObject cardPrefab;

    [HideInInspector]
    public Canvas canvas;

    void Awake()
    {
        canvas = GetComponentInParent<Canvas>();
    }

    public void FillHand()
    {
        StartCoroutine(DrawCards());
    }

    IEnumerator DrawCards()
    {
        while (transform.childCount != 5)
        {
            yield return new WaitForSeconds(0.2f);
            Instantiate(cardPrefab, transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
