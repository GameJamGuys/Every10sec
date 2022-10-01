using UnityEngine;

public class InitSystem : PersistentSingleton<Systems>
{
    private void OnEnable()
    {
        Debug.Log("Init");
    }

    private void OnDisable()
    {

    }
    
}
