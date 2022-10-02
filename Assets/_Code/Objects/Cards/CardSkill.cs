using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSkill : MonoBehaviour
{
    public SkillType skillType;
    public GameObject[] skillItems;
    public BaseSkill skill;
    //public BaseSkill[] skills;

    public void SetSkill(SkillType type)
    {
        foreach(GameObject item in skillItems)
        {
            if (item.GetComponent<BaseSkill>().skillType == type)
                item.SetActive(true);
        }
    }

    public void RandomSkill()
    {
        transform.DeactiveChildren();
        int random = Random.Range(0, skillItems.Length);
        skillItems[random].SetActive(true);
        skill = skillItems[random].GetComponent<BaseSkill>();
    }
}

public enum SkillType
{
    Attack,
    Shield,
    Heal,
}
