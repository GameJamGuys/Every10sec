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

    public void ResetHand()
    {
        StartCoroutine(RemoveByOne());
    }

    IEnumerator RemoveByOne()
    {
        AudioSystem.Instance.PlaySound("ResetCards");
        while (transform.childCount > 0)
        {
            Destroy(transform.GetChild(0).gameObject);
            Debug.Log("Card remove");
            yield return new WaitForSeconds(0.02f);
        }
        FillHand();
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
            Debug.Log("Card draw");
            AudioSystem.Instance.PlaySound("TakeCard");
            Instantiate(cardPrefab, transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
