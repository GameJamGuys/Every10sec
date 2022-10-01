using System;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTemplate", menuName = "Data/Template")]
public class ScriptableTemplate : ScriptableObject
{
    public string dataName = "Template";

    public TypeEnum type;

    [SerializeField]
    private StatStruct _stats;
    public StatStruct Stats => _stats;

    [TextArea]
    public string Description;
}

[Serializable]
public struct StatStruct
{
    public int stat1;
    public int stat2;
    public int stat3;
}

[Serializable]
public enum TypeEnum
{
    type0 = 0,
    type1 = 1,
    type2 = 2
}