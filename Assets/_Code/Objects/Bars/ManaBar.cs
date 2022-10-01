using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaBar : BaseBar
{
    private void Start()
    {
        maxAmount = PlayerManager.Instance.playerMP;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
