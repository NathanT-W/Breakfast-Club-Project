using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCountdown : MonoBehaviour
{
    public float timer = 50f;
    private Text timerSeconds;
    public GameObject Player;

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

            Application.LoadLevel("MainMenu");
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }

    }
}
