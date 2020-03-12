using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FryingPanScript : MonoBehaviour {

    public Material cookedBacon;

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
                Vector3 originalPos = Col.GetComponent<PickupItems>().originalPos;
                Quaternion originalRot = Col.GetComponent<PickupItems>().originalRot;
                Instantiate(Col, originalPos, originalRot);
                Col.tag = "cookedBacon";
                Col.GetComponent<MeshRenderer>().material = cookedBacon;
                break;
        }
    }
}
