using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBar : MonoBehaviour
{
    public GameObject popPrefab;
    public int maxAmount = 5;

    public virtual void Set(int setAmount)
    {
        int newAmount = Mathf.Clamp(setAmount, 0, maxAmount);
        transform.DestroyChildren();

        while(newAmount > 0)
        {
            Instantiate(popPrefab, transform);
            newAmount--;
        }
    }
}
