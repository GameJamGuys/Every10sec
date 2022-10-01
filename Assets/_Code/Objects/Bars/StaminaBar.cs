using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaBar : BaseBar
{
    private void Start()
    {
        maxAmount = PlayerManager.Instance.playerSP;
    }

    void Update()
    {
        
    }
}
