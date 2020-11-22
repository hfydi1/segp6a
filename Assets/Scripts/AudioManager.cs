using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    public static AudioManager instance; //reference to current AudioManager in scene

    // Start is called before the first frame update
    void Awake()
    {

        //Makes sure there is only one AudioManager in the entire Unity project
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return; //make sure no more code is destroyed
        }

        //Make sure the audio isnt destroyed upon new scene load
        DontDestroyOnLoad(gameObject);
        
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start() //to play sound upon game start
    {
        Play("AmbientNoise");
    }

    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null) //script wont try play sound that doesnt exist/cant be found
        {
            Debug.LogWarning("Sounds: " + name + " not found");
            return;
        }
        s.source.Play();
    }
}
