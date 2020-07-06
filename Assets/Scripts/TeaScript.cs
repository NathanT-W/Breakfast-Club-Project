using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaScript : MonoBehaviour {

    void OnTriggerenter(Collider col)
    {
        if (col.gameObject.tag == "Milk")
        {
            switch (gameObject.tag)
            {
                case "EmptyCup":
                    break;
                case "EmptyMug":
                    break;
                case "TeaMug":
                    break;
                case "TeaCup":
                    break;
            }
        }

    }


}
