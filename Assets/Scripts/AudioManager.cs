using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.volume = s.volume;    
        }
    }

    // Update is called once per frame
    public void Play (string clipName)
    {
        Sound s = Array.Find(sounds, s => s.clipName == clipName);
        s.source.Play();
    }
}
    