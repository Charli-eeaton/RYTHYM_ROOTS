using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;
using System;

public class SongManager : MonoBehaviour
{
    public Sound[] music;

    public static SongManager Instance;
    public AudioSource audioSource;

    public Lane[] lanes;
    public float songDelayInSeconds;
    public double marginOfError;
    public float inputDelayInSeconds;

    public int inputDelayInMilliseconds;

    public string fileLocation;
    public float noteTime;
    public float noteSpawnY;
    public float noteTapY;
    private float noteDespawn;
    public float noteDespawnY   
    {
        get
        {
            
            noteDespawn = noteTapY - (noteSpawnY - noteTapY);
            UnityEngine.Debug.Log(noteDespawn);
            if (noteDespawn > 1)
            {
                noteDespawn = 1;
            }
            return noteDespawn;
            
            //return noteTapY - (noteSpawnY - noteTapY);
        }
    }

    public static MidiFile midiFile;
    bool playerDeath = false;

    void Awake()
    {
        foreach (Sound m in music)
        {
            m.source = gameObject.AddComponent<AudioSource>();
            m.source.clip = m.clip;

            m.source.volume = m.volume;

        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        ReadFromFile();
    }

    private void ReadFromFile()
    {
        midiFile = MidiFile.Read(Application.streamingAssetsPath + "/" + fileLocation);
        GetDataFromMidi();
    }

    public void GetDataFromMidi()
    {
        var notes = midiFile.GetNotes();
        var array = new Melanchall.DryWetMidi.Interaction.Note[notes.Count];
        notes.CopyTo(array, 0);

        foreach (var lane in lanes)
        {
           lane.SetTimeStamps(array);
        }

        Invoke(nameof(StartSong), songDelayInSeconds);
    }

    public void StartSong(string clipName)
    {
        Sound m = Array.Find(music, m => m.clipName == clipName);
        m.source.Play();
        //audioSource.Play();
        
    }

    public void StopSong(string clipName)
    {
        Sound m = Array.Find(music, m => m.clipName == clipName);
        m.source.Stop();
    }

    public void changeTrackLayer(string clipName)
    {
        Sound m = Array.Find(music, m => m.clipName == clipName);
        if (m.volume != 1)
        {
            m.volume = 1f;
        }
        else
        {
            m.volume = 0f;
        }
        
    }

    public static double GetAudioSourceTime()
    {
        return (double)Instance.audioSource.timeSamples / Instance.audioSource.clip.frequency;  
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void killSwitch(bool playerDeathState)
    {
        playerDeath = playerDeathState;
        //ChangePlayerDeath(playerDeath);
        returnPlayerDeath();
        UnityEngine.Debug.Log(playerDeath);
        if (playerDeath == true)
        {
            //Time.timeScale = 0;
            //Destroy(gameObject);
            //(transform.GetComponent<Lane>() as MonoBehaviour).enabled = false;
        }
        if (playerDeath == false)
        {
        }
    }

    public void ChangePlayerDeath(bool playerDeathState)
    {
        playerDeath = playerDeathState;
        GetDataFromMidi();

    }

    public bool returnPlayerDeath()
    {
        return playerDeath;
    }

}
