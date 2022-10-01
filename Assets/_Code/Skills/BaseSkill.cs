using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSkill : MonoBehaviour
{
    private void Start()
    {
        transform.DeactiveChildren();
    }

    public void SetUp()
    {
        transform.ActiveChildren();
    }

}
