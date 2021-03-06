﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFF_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";

    public static void UnlockLevel(int level)
    {
        if (level > SceneManager.sceneCountInBuildSettings - 1)
        {
            Debug.LogError("Master volume out of range");
            return;
        }

        PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
    }

    public static bool IsLevelUnlocked(int level)
    {
        if (PlayerPrefs.GetInt(LEVEL_KEY + level.ToString()) == 1)
            return true;
        return false;
    }

    #region volume
    public static void SetVolume(float value)
    {
        if (!(value > 0f && value < 1f))
        {
            Debug.LogError("Out of range");
            return;
        }

        PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, value);
    }

    public static float GetVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
    #endregion volume


    #region difficulty
    public static void SetDifficulty(float value)
    {
        if (!(value > 0f && value < 3.1f))
        {
            Debug.LogError("Out of range");
            return;
        }

        PlayerPrefs.SetFloat(DIFF_KEY, value);
    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFF_KEY);
    }
    #endregion difficulty controls
}
