﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class serveFoodScript : MonoBehaviour {

    public GameObject timer;
    public GameObject player;

    void OnTriggerEnter(Collider Col)
    {

        if (Col.GetComponent<Plate_Food_Script>().food.egg == true && Col.GetComponent<Plate_Food_Script>().food.bacon == true)
        {
            if (string.Equals(Col.GetComponent<Plate_Food_Script>().food.Egg.tag, "cookedEgg") && string.Equals(Col.GetComponent<Plate_Food_Script>().food.Bacon.tag, "cookedBacon"))
            {
                timer.GetComponent<TimerCountdown>().enabled = false;
                timer.GetComponent<Text>().text = "You Win!";
            }
            else
            {
                Debug.Log("Lose");
            }
        }
        else
        {
            Time.timeScale = 1f;
            player.GetComponent<FirstPersonController>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Application.LoadLevel("MainMenu");
        }

        Destroy(Col.gameObject);
    }
}