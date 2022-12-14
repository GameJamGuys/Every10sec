using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public Image uiFill;
    public TMP_Text uiText;

    public Color badColor;
    public Color goodColor;

    public int timerTime;

    public void SetTime(int time)
    {
        if (time == 10) Reset();
        uiText.text = time.ToString();
        uiFill.fillAmount = (float)time/10;
        if (time == 0) ZeroTime();
    }

    public void Reset()
    {
        uiFill.color = Color.white;
    }

    public void ZeroTime()
    {
        //ebug.Log("Zero time");
        bool good = SlotManager.Instance.IsAllGood();
        uiFill.fillAmount = 1;
        if (good) uiFill.color = goodColor;
        else uiFill.color = badColor;
    }
}
