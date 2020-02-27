﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;

    void Update() { 
        if (Input.GetKeyDown(KeyCode.P))
    {
        if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
    }

    }

    public void Resume ()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Pause ()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
    }

   

    public void ResetLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
