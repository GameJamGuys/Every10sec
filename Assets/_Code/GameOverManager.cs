using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : StaticInstance<GameOverManager>
{
    public bool gameCondition;
    public bool isGameEnd;
    public GameObject gameOverBack;
    public GameObject loseState;
    public GameObject winState;

    public void ShowLose()
    {
        Time.timeScale = 0f;
        gameOverBack.SetActive(true);
        loseState.SetActive(true);
        winState.SetActive(false);
    }

    public void ShowWin()
    {
        Time.timeScale = 0f;
        gameOverBack.SetActive(true);
        winState.SetActive(true);
        loseState.SetActive(false);
    }
}
