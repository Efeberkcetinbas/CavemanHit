using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudionManager : MonoBehaviour
{

    public Sound[] sounds;

    //singleton design pattern
    public static AudionManager Instance;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }


        //Bu sayede tekrar yüklememize ve müziğin bölünmesine gerek kalmıyor.
        //DontDestroyOnLoad(gameObject);

        foreach(Sound s in sounds)
        {
            //Runtime da audiosource ekliyoruz.
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    //Eğer background istiyorsan bunu kullan.
    /*void Start()
    {
        Play_Sound("Theme");
    }*/

    public void Play_Sound(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        
        //Eğer boş ise;
        if (s == null)
            return;

        s.source.Play();
    }
}
