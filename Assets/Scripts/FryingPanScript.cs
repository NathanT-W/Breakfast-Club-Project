using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FryingPanScript : MonoBehaviour {

    public Material cookedBacon;
    public Material cookedEgg;
    public Mesh cookedEggMesh;

    public GameObject fryingPan;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider Col)
    {
        Vector3 originalPosition = Col.GetComponent<PickupItems>().originalPos;
        Quaternion originalRotation = Col.GetComponent<PickupItems>().originalRot;

        Instantiate(Col, originalPosition, originalRotation);

        switch (Col.gameObject.tag)
        {
            case "Toast":

                break;
            case "Egg":                
                Col.tag = "cookedEgg";
                Col.GetComponent<MeshRenderer>().material = cookedEgg;
                Col.GetComponent<MeshFilter>().mesh = cookedEggMesh;
                break;
            case "Bacon":
                Col.tag = "cookedBacon";
                Col.GetComponent<MeshRenderer>().material = cookedBacon;
                break;
                
        }

        fryingPan.GetComponents<Collider>()[0].enabled = false;
    }

    void OnCollisionExit(Collision other)
    {
        fryingPan.GetComponents<Collider>()[0].enabled = true;
    }
}
