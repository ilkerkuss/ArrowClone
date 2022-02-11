using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]


public class Audio
{

    public string AudioName;
    public AudioClip AudioClip;

    [Range(0f, 1f)]
    public float Volume;

    [Range(-3f, 3f)]
    public float Pitch;

    public bool SoundLoop;

    [HideInInspector]
    public AudioSource AudioSource;




}
