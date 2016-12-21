﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{


    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);

    }

    public void QuitRequest(string name)
    {
        Application.Quit();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}