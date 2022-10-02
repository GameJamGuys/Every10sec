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

    }

    public void ShieldDown()
    {

    }

    IEnumerator Blink(GameObject cut)
    {
        cut.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        cut.SetActive(false);
    }

    public void RecieveAttack(BossAttackType type)
    {
        switch (type)
        {
            case BossAttackType.Left:
                PlayerManager.Instance.AddHp(-bossPower);
                Blink(lCut);
                break;
            case BossAttackType.Right:
                PlayerManager.Instance.AddHp(-bossPower);
                Blink(rCut);
                break;
            case BossAttackType.Both:
                PlayerManager.Instance.AddHp(-bossPower * 2);
                Blink(lCut);
                Blink(rCut);
                break;
        }
    }


}
