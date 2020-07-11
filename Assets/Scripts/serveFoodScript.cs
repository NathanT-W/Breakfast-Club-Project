using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class serveFoodScript : MonoBehaviour {

    bool flag1 = false;
    bool flag2 = false;
    public GameObject timer;
    public GameObject VictoryNotif;
    public GameObject player;

    void Update()
    {
        if (flag1 == true && flag2 == true)
        {
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
        if (gameObject.tag == "Level1")
        {
            if (Col.GetComponent<Plate_Food_Script>().food.egg == true && Col.GetComponent<Plate_Food_Script>().food.bacon == true)
            {
                if (string.Equals(Col.GetComponent<Plate_Food_Script>().food.Egg.tag, "cookedEgg") && string.Equals(Col.GetComponent<Plate_Food_Script>().food.Bacon.tag, "cookedBacon"))
                {
                    flag1 = true;
                    flag2 = true;
                }
                else
                {
                    Time.timeScale = 1f;
                    player.GetComponent<FirstPersonController>().enabled = false;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    Application.LoadLevel("MainMenu");
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
        }
        else if(gameObject.tag == "Level2")
        {
            if (Col.GetComponent<Plate_Food_Script>().food.toast == true && Col.GetComponent<Plate_Food_Script>().food.tea == true)
            {
                if (string.Equals(Col.GetComponent<Plate_Food_Script>().food.Toast.tag, "Toast") && string.Equals(Col.GetComponent<Plate_Food_Script>().food.Tea.tag, "FinishedCup") && flag1 == false)
                {
                    flag1 = true;
                }
                else
                {
                    Time.timeScale = 1f;
                    player.GetComponent<FirstPersonController>().enabled = false;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    Application.LoadLevel("MainMenu");
                }
            }
            else if (Col.GetComponent<Plate_Food_Script>().food.bacon == true && Col.GetComponent<Plate_Food_Script>().food.egg == true && flag2 == false)
            {
                if (string.Equals(Col.GetComponent<Plate_Food_Script>().food.Bacon.tag, "cookedBacon") && string.Equals(Col.GetComponent<Plate_Food_Script>().food.Egg.tag, "cookedEgg"))
                {
                    flag2 = true;
                }
                else
                {
                    Time.timeScale = 1f;
                    player.GetComponent<FirstPersonController>().enabled = false;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    Application.LoadLevel("MainMenu");
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
        }

        Destroy(Col.gameObject);
    }
}