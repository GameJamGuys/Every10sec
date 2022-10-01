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
        timerTime = fixTime;
        timer.SetTime(timerTime);
        while (timerTime > 0)
        {
            yield return new WaitForSeconds(1f);
            timerTime--;
            timer.SetTime(timerTime);
        }

        yield return new WaitForSeconds(1f);
        TimeOut();
    }

    void TimeOut()
    {
        StartCoroutine(LaunchTimer());
    }
}
