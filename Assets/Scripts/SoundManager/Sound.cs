using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;

    public AudioClip clip;

    //Range'e 0 ve 1 arasında değer veriyoruz.
    [Range(0f,1f)]
    public float volume;

    [Range(.1f,3f)]
    public float pitch;

    //inspectorda gözükmüyor
    [HideInInspector]
    public AudioSource source;

}
