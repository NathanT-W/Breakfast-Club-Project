using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate_Food_Script : MonoBehaviour {

    public GameObject plate;

    public struct Food
    {
        public bool egg;
        public GameObject Egg;
        public bool bacon;
        public GameObject Bacon;
        public bool toast;
        public GameObject Toast;
    };

    public Food food;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if(food.egg == true)
        {
            food.Egg.transform.position = plate.transform.position + new Vector3(0.05f,0.05f,0);
        }
        if (food.bacon == true)
        {
            food.Bacon.transform.position = plate.transform.position + new Vector3(-0.1f, 0.03f, 0);
            food.Bacon.transform.rotation = plate.transform.rotation;

        }
    }

    void OnTriggerEnter(Collider Col) {
        switch (Col.gameObject.tag)
        {
            case "Toast":
                food.toast = true;
                food.Toast = Col.gameObject;
                break;
            case "Egg":
                food.egg = true;
                food.Egg = Col.gameObject;
                food.Egg.GetComponent<Rigidbody>().isKinematic = true;
                break;
            case "Bacon":
                food.bacon = true;
                food.Bacon = Col.gameObject;
                food.Bacon.GetComponent<Rigidbody>().isKinematic = true;
                break;
        }
    }
}
