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

    public void AddCards()
    {
        while (transform.childCount != 5)
        {
            Instantiate(cardPrefab, transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
