﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FryingPanScript : MonoBehaviour {

    public Material cookedBacon;
    public Material cookedEgg;
    public Mesh cookedEggMesh;

    public GameObject fryingPan;

    void OnTriggerEnter(Collider Col)
    {
        Vector3 originalPosition = Col.GetComponent<PickupItems>().originalPos;
        Quaternion originalRotation = Col.GetComponent<PickupItems>().originalRot;

        switch (Col.gameObject.tag)
        {

            // Swap food with cooked version of food

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
