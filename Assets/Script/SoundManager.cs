using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioClip WinSound;

    private AudioSource audio;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(WinSound);
        }
        else
        {
            instance = this;
        }
        audio = GetComponent<AudioSource>();
    }

    public void WindSOundStart()
    {
        audio.PlayOneShot(WinSound);
    }

}
