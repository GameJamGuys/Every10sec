using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public bool gameCondition;
    public GameObject loseState;
    public GameObject winState;

    public void Start()
    {
        if (gameCondition == true)
        {
            winState.SetActive(true);
        }
        else
        {
            loseState.SetActive(true);
        }
    }

}
