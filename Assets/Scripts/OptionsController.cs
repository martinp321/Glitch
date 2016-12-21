using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{

    public Slider volumeSlider;
    public Slider difficultySlider;

    private MusicManager musicManager;

    // Use this for initialization
    void Start()
    {
        musicManager = GameObject.FindObjectOfType<MusicManager>();

        volumeSlider.value = PlayerPrefsManager.GetVolume();
        difficultySlider.value = PlayerPrefsManager.GetDifficulty();
    }

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetVolume(volumeSlider.value);
        PlayerPrefsManager.SetDifficulty(difficultySlider.value);
    }

    public void Update()
    {
        musicManager.ChangeVolume(volumeSlider.value);
    }
}
