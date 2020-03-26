using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serveFoodScript : MonoBehaviour {

    public GameObject timer;

    void OnTriggerEnter(Collider Col)
    {

        if (Col.GetComponent<Plate_Food_Script>().food.egg == true && Col.GetComponent<Plate_Food_Script>().food.bacon == true)
        {
            if (string.Equals(Col.GetComponent<Plate_Food_Script>().food.Egg.tag, "cookedEgg") && string.Equals(Col.GetComponent<Plate_Food_Script>().food.Bacon.tag, "cookedBacon"))
            {
                timer.GetComponent<TimerCountdown>().enabled = false;
            }
            else
            {
                Debug.Log("Lose");
            }
        }
        else
        {
            Debug.Log("Lose");
        }

        Destroy(Col.gameObject);
    }
}