using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioClip menuMusic;
    public AudioClip gameMusic;

    private AudioSource audioSource;

    static private MusicManager instance;

    // follows singleton pattern
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
            audioSource = GetComponent<AudioSource>();
        } else
        {
            Destroy(this);
            return;
        }
    }

    private void Start()
    {
        PlayMenuMusic();
    }

    static public void PlayMenuMusic()
    {
        if (instance != null)
        {
            if (instance.audioSource != null)
            {
                instance.audioSource.Stop();
                instance.audioSource.clip = instance.menuMusic;
                instance.audioSource.Play();
            }
        }
    }

    static public void PlayGameMusic()
    {
        if (instance != null)
        {
            if (instance.audioSource != null)
            {
                instance.audioSource.Stop();
                instance.audioSource.clip = instance.gameMusic;
                instance.audioSource.Play();
            }
        }
    }
}
