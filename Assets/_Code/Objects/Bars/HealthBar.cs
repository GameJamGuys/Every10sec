using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public int maxHealth;

    public Image fillImage;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = PlayerManager.Instance.playerHP;
    }

    public void Set(int setAmount)
    {
        float newAmount = Mathf.Clamp(setAmount, 0, maxHealth);

        float newFillAmount = newAmount / maxHealth;
        Debug.Log(newFillAmount);
        fillImage.fillAmount = newFillAmount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}