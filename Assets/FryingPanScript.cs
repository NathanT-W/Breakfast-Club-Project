using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FryingPanScript : MonoBehaviour {

    public GameObject cookedBacon;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider Col)
    {
        switch (Col.gameObject.tag)
        {
            case "Toast":

                break;
            case "Egg":

                break;
            case "Bacon":
                Instantiate(cookedBacon, transform.position, transform.rotation);
                Destroy(Col.gameObject);
                break;
        }
    }
}
