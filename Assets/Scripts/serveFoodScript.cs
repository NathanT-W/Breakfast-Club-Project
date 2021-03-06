﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ServeFoodScript : MonoBehaviour {

    bool flag1 = false;
    bool flag2 = false;
  
    public GameObject timer;
    public GameObject VictoryNotif;
    public GameObject failNotif;
    public GameObject player;

    public GameObject Note1;     // notes are gives objects to the player, they're on by default. Deividas Vengalis//
    public GameObject Note2;

    void Update()
    {
        if (flag1 == true && flag2 == true)
        {
            Time.timeScale = 0f;
            timer.GetComponent<TimerCountdown>().enabled = false;
            player.GetComponent<FirstPersonController>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            VictoryNotif.gameObject.SetActive(true);
            timer.GetComponent<Text>().text = "";
        }
    }

    void OnTriggerEnter(Collider Col)
    {

        // Check which level it is

        if (gameObject.tag == "Level1")
        {
            if (Col.GetComponent<PlateFoodScript>().food.egg == true && Col.GetComponent<PlateFoodScript>().food.bacon == true)
            {
                if (string.Equals(Col.GetComponent<PlateFoodScript>().food.Egg.tag, "cookedEgg") && string.Equals(Col.GetComponent<PlateFoodScript>().food.Bacon.tag, "cookedBacon"))
                {
                    flag1 = true;
                    flag2 = true;
                }
                else
                {

                    // Display fail ui

                    Time.timeScale = 0f;
                    timer.GetComponent<TimerCountdown>().enabled = false;
                    player.GetComponent<FirstPersonController>().enabled = false;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    failNotif.SetActive(true);

                }
            }
            else
            {

                // Display fail ui

                Time.timeScale = 0f;
                timer.GetComponent<TimerCountdown>().enabled = false;
                player.GetComponent<FirstPersonController>().enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                failNotif.SetActive(true);
            }
        }
        else if(gameObject.tag == "Level2")
        {
            if (Col.GetComponent<PlateFoodScript>().food.toast == true && Col.GetComponent<PlateFoodScript>().food.tea == true)
            {
                if (string.Equals(Col.GetComponent<PlateFoodScript>().food.Toast.tag, "Toast") && string.Equals(Col.GetComponent<PlateFoodScript>().food.Tea.tag, "FinishedCup"))
                {
                    flag1 = true;
                    Note1.SetActive(false); // objective is done. //
                }
                else
                {

                    // Display fail ui

                    Time.timeScale = 0f;
                    timer.GetComponent<TimerCountdown>().enabled = false;
                    player.GetComponent<FirstPersonController>().enabled = false;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    failNotif.SetActive(true);
                }
            }
            else if (Col.GetComponent<PlateFoodScript>().food.bacon == true && Col.GetComponent<PlateFoodScript>().food.egg == true)
            {
                if (string.Equals(Col.GetComponent<PlateFoodScript>().food.Bacon.tag, "cookedBacon") && string.Equals(Col.GetComponent<PlateFoodScript>().food.Egg.tag, "cookedEgg"))
                {
                    flag2 = true;
                    Note2.SetActive(false);
                }
                else
                {

                    // Display fail ui

                    Time.timeScale = 0f;
                    timer.GetComponent<TimerCountdown>().enabled = false;
                    player.GetComponent<FirstPersonController>().enabled = false;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    failNotif.SetActive(true);
                }
            }
            else
            {

                // Display fail ui

                Time.timeScale = 0f;
                timer.GetComponent<TimerCountdown>().enabled = false;
                player.GetComponent<FirstPersonController>().enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                failNotif.SetActive(true);
            }
        }

        Destroy(Col.gameObject);
    }
}