using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetHand : MonoBehaviour
{
    public int healthCost;
    public CardHolder holder;
    Button button;

    bool canReset;
    float timer;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Reset);
        timer = 0;
        canReset = true;
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if (!canReset) canReset = true;


    }

    private void Reset()
    {
        if (canReset)
        {
            PlayerManager.Instance.AddHp(-healthCost);
            holder.ResetHand();
            timer = 1f;
            canReset = false;
        }
    }
}
