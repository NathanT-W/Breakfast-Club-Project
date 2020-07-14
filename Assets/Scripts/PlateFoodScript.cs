using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateFoodScript : MonoBehaviour {

    public GameObject plate;

    public struct Food
    {
        public bool egg;
        public GameObject Egg;
        public bool bacon;
        public GameObject Bacon;
        public bool toast;
        public GameObject Toast;
        public bool tea;
        public GameObject Tea;
    };

    public Food food;

    // Use this for initialization
    void Start () {
        food.egg = false;
        food.bacon = false;
        food.toast = false;
        food.tea = false;
    }
	
	// Update is called once per frame
	void Update () {
        if(food.egg == true)
        {
            food.Egg.transform.parent = plate.transform;
            food.Egg.transform.rotation = plate.transform.rotation;
        }
        if (food.bacon == true)
        {
            food.Bacon.transform.parent = plate.transform;
            food.Bacon.transform.rotation = plate.transform.rotation;
        }
        if (food.toast == true)
        {
            food.Toast.transform.parent = plate.transform;
        }
        if (food.tea == true)
        {
            food.Tea.transform.parent = plate.transform;
        }
    }

    void OnTriggerEnter(Collider Col) {
        switch (Col.gameObject.tag)
        {
            case "bread":
            case "Toast":
                food.toast = true;
                food.Toast = Col.gameObject;
                food.Toast.GetComponent<Rigidbody>().isKinematic = true;
                Destroy(food.Toast.GetComponent<PickupItems>());
                break;
            case "Egg":
            case "cookedEgg":
                food.egg = true;
                food.Egg = Col.gameObject;
                food.Egg.GetComponent<Rigidbody>().isKinematic = true;
                Destroy(food.Egg.GetComponent<PickupItems>());
                break;
            case "Bacon":
            case "cookedBacon":
                food.bacon = true;
                food.Bacon = Col.gameObject;
                food.Bacon.GetComponent<Rigidbody>().isKinematic = true;
                Destroy(food.Bacon.GetComponent<PickupItems>());
                break;
            case "EmptyCup":
            case "TeaCup":
            case "MilkCup":
            case "FinishedCup":
                food.tea = true;
                food.Tea = Col.gameObject;
                food.Tea.GetComponent<Rigidbody>().isKinematic = true;
                Destroy(food.Tea.GetComponent<PickupItems>());
                break;
        }
    }
}
