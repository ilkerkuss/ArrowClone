using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public Audio[] _audios;
    private AudioSource _audioSource;


    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Init();
    }


    public void Init()
    {

        foreach (Audio au in _audios)
        {
            au.AudioSource = gameObject.AddComponent<AudioSource>();
            au.AudioSource.clip = au.AudioClip;
            au.AudioSource.volume = au.Volume;
            au.AudioSource.loop = au.SoundLoop;
            au.AudioSource.pitch = au.Pitch;


        }

    }

    public void PlaySound(string name)
    {
        foreach (Audio au in _audios)
        {
            if (au.AudioName == name)
                au.AudioSource.Play();
        }
    }
    public void StopSound(string name)
    {
        foreach (Audio au in _audios)
        {
            if (au.AudioName == name)
                au.AudioSource.Stop();
        }
    }

    public void MuteSounds()
    {
        foreach (Audio au in _audios)
        {
            au.AudioSource.volume = 0;
        }
    }

    public void UnMuteSounds()
    {
        foreach (Audio au in _audios)
        {
            au.AudioSource.volume = 0.4f;
        }
    }
}
