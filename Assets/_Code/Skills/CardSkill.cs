using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSkill : MonoBehaviour
{
    public SkillType skillType;
    public GameObject[] skillItems;
    //public BaseSkill[] skills;

    void Start()
    {
        
    }

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
    }
}

public enum SkillType
{
    Attack,
    SwordAttack,
    ThunderBolt,
    FireBall,
    Shield,
    Heal,
    AddMana,
    AddStamina
}
