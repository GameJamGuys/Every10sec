using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSkill : MonoBehaviour
{
    public SkillType skillType;

    [Range(-10, 10)]
    public int hp;
    [Range(-3, 3)]
    public int mp;
    [Range(-3, 3)]
    public int sp;

    private void Start()
    {
        transform.DeactiveChildren();
    }

    public void SetUp()
    {
        transform.ActiveChildren();
    }

    public virtual void UseSkill()
    {
        PlayerManager.Instance.AddStats(hp * 10, mp, sp);
    }

}
