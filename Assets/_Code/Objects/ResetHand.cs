using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetHand : MonoBehaviour
{
    public int healthCost;
    public CardHolder holder;
    Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Reset);
    }

    private void Reset()
    {
        PlayerManager.Instance.AddHp(-healthCost);
        holder.ResetHand();
    }
}
