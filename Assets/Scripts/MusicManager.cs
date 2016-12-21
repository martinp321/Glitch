using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ChangeVolume(float volume)
    {
        audioSource.volume = volume;
    }

    private void OnLevelWasLoaded(int level)
    {
        if (levelMusicChangeArray[level])
        {
            AudioClip thisLevelMusic = levelMusicChangeArray[level];
            if (thisLevelMusic)
            {
                if (audioSource.clip == thisLevelMusic)
                    return;

                audioSource.clip = thisLevelMusic;
                audioSource.loop = true;
                audioSource.Play();
            }
        }
    }
}
