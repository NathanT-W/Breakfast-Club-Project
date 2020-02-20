using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate_Food_Script : MonoBehaviour {

    public struct Food
    {
        public bool fried_egg;
        public bool cooked_bacon;
        public bool toast;
    };

    public Food food;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(food.toast);
        Debug.Log(food.fried_egg);
        Debug.Log(food.cooked_bacon);
    }

    void OnTriggerEnter(Collider Col) {
        switch (Col.gameObject.tag)
        {
            case "Toast":
                food.toast = true;
                break;
            case "Egg":
                food.fried_egg = true;
                break;
            case "Bacon":
                food.cooked_bacon = true;
                break;
        }
    }
}
