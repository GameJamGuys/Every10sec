using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSkill : MonoBehaviour
{
    public SkillType skillType;

    [Range(0, 100)]
    public int hp;
    [Range(0, 5)]
    public int mp;
    [Range(0, 5)]
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
        PlayerManager.Instance.AddStats(hp, mp, sp);
    }

}
