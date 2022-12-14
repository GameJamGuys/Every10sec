using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;

    public AudioClip clip;

    //[Range(0f, 1f)]
    [HideInInspector]
    public float volume = 0.5f;
    //[Range(0.1f, 3f)]
    [HideInInspector]
    public float pitch = 1f;
    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
