using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : StaticInstance<PlayerLogic>
{
    public GameObject shield;
    [HideInInspector]
    public int shieldCount;

    int bossPower;

    void Start()
    {
        bossPower = BossLogic.Instance.bossAttack;
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

    public void RecieveAttack(BossAttackType type)
    {
        switch (type)
        {
            case BossAttackType.Left:
                PlayerManager.Instance.AddHp(-bossPower);
                break;
            case BossAttackType.Right:
                PlayerManager.Instance.AddHp(-bossPower);
                break;
            case BossAttackType.Both:
                PlayerManager.Instance.AddHp(-bossPower * 2);
                break;
        }
    }
}
