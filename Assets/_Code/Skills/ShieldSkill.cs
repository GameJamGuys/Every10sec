using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSkill : BaseSkill
{
    [Range(1,3)]
    public int shields;

    public override void UseSkill()
    {
        base.UseSkill();

    }
}
