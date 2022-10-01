using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetCards : MonoBehaviour
{
    public GameObject _cardPrefab;
    public GameObject _handPrefab;

    public void CardsDrag()
    {
        GameObject card = Instantiate(_cardPrefab, _handPrefab.transform);
    }
}
