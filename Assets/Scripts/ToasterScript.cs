using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToasterScript : MonoBehaviour {

    void OnTriggerEnter(Collider Col)
    {
        Vector3 originalPosition = Col.GetComponent<PickupItems>().originalPos;
        Quaternion originalRotation = Col.GetComponent<PickupItems>().originalRot;

        Instantiate(Col, originalPosition, originalRotation);

        switch (Col.gameObject.tag)
        {
            case "bread":
                Col.gameObject.GetComponent<Renderer>().material.color = Color.grey;
                Col.gameObject.tag = "Toast";
                break;
        }

        gameObject.GetComponents<BoxCollider>()[0].enabled = false;
    }

    void OnCollisionExit(Collision other)
    {
        gameObject.GetComponents<BoxCollider>()[0].enabled = true;
    }
}
