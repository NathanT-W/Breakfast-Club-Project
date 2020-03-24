using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serveFoodScript : MonoBehaviour {

    void OnTriggerEnter(Collider Col)
    {

        if (Col.GetComponent<Plate_Food_Script>().food.egg == true)
        {
            Debug.Log(Col.GetComponent<Plate_Food_Script>().food.Egg.tag);
        }
        else
        {
            Debug.Log(0);
        }

        if (Col.GetComponent<Plate_Food_Script>().food.bacon == true)
        {
            Debug.Log(Col.GetComponent<Plate_Food_Script>().food.Bacon.tag);
        }
        else
        {
            Debug.Log(0);
        }



        Destroy(Col.gameObject);
    }
}