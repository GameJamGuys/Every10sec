using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    static int fixTime = 10;
    [HideInInspector]
    public int timerTime;

    public Timer timer;

    void Start()
    {
        StartCoroutine(LaunchTimer());
    }

    IEnumerator LaunchTimer()
    {
        AudioSystem.Instance.PlaySound("Timer");
        timerTime = fixTime;
        timer.SetTime(timerTime);
        while (timerTime > 0)
        {
            yield return new WaitForSeconds(1f);
            timerTime--;
            timer.SetTime(timerTime);
        }
        TimeOut();
        yield return new WaitForSeconds(1f);
        Restart();
    }
    void Restart() => StartCoroutine(LaunchTimer());

    void TimeOut()
    {
        Debug.Log("TimeOut");
        BattleManager.Instance.BossTryAttack();
        BattleManager.Instance.DrawCards();
        SlotManager.Instance.ResetSlots();
    }

    
}
