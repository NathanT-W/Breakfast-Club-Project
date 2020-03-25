using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class UIManager : MonoBehaviour {

    public bool GameIsPaused = false;

    public GameObject Player;

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
        Player.GetComponent<FirstPersonController>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Pause ()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Player.GetComponent<FirstPersonController>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

   

    public void ResetLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
        GameIsPaused = false;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
