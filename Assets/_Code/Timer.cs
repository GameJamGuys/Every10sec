using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image uiFill;
    [SerializeField] public Text uiText;

    public int _duration;

    private int remaingDuration;

    private void Start()
    {
        Being(_duration);
    }

    private void Being(int Second)
    {
        remaingDuration = Second;
        StartCoroutine(UpdateTimer());
    }

    private void Update()
    {
        uiFill.fillAmount -= Time.deltaTime;
        if (uiFill.fillAmount == 0) { uiFill.fillAmount = 1; }
    }

    private IEnumerator UpdateTimer()
    {
        while (remaingDuration>=0)
        {
            uiText.text = $"{remaingDuration}";
          
            remaingDuration--;
            yield return new WaitForSeconds(1f);
        }
        OnEnd();
    }

    private void OnEnd()
    {
        print("End");
    }
}
