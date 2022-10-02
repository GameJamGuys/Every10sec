using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : StaticInstance<PlayerLogic>
{
    public GameObject shield;
    [HideInInspector]
    public int shieldCount;

    public GameObject lCut;
    public GameObject rCut;

    int bossPower;

    void Start()
    {
        bossPower = BossLogic.Instance.bossAttack;
        shield.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShieldUp()
    {
        Debug.Log("Shield up");
        shield.SetActive(true);
        shieldCount = 1;
    }

    public void ShieldDown()
    {
        Debug.Log("Shield down");
        shield.SetActive(false);
        shieldCount = 0;
    }

    IEnumerator Blink(GameObject cut)
    {
        cut.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        cut.SetActive(false);
    }

    public void RecieveAttack(BossAttackType type)
    {
        if(shieldCount > 0)
        {
            Debug.Log("Shield used");
            ShieldDown();
            return;
        }
        switch (type)
        {
            case BossAttackType.Left:
                PlayerManager.Instance.AddHp(-bossPower);
                StartCoroutine(Blink(lCut));
                break;
            case BossAttackType.Right:
                PlayerManager.Instance.AddHp(-bossPower);
                StartCoroutine(Blink(rCut));
                break;
            case BossAttackType.Both:
                PlayerManager.Instance.AddHp(-bossPower * 2);
                StartCoroutine(Blink(lCut));
                StartCoroutine(Blink(rCut));
                break;
        }
    }


}
