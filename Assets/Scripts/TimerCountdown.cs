﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class TimerCountdown : MonoBehaviour
{
    public bool GameIsPaused = false;
    public float timer = 59f;
    private Text timerSeconds;
    public GameObject Player;
    public GameObject FailMenuUI;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f0");
        if (timer <= 0)
        {

            Time.timeScale = 1f;
            player.GetComponent<FirstPersonController>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Application.LoadLevel("MainMenu");

        }

    }
}
