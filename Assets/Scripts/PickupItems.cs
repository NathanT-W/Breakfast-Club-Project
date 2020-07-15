using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PickupItems : MonoBehaviour {

    public GameObject item;
    public GameObject tempParent;
    public Transform guide;
    public GameObject player;
    public Vector3 originalPos;
    public Quaternion originalRot;

    void OnMouseDown() {
        if(player.GetComponent<FirstPersonController>().pickedUp == false)
        {
            // Attach object to guide, infront of player

            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().isKinematic = true;
            item.transform.position = guide.transform.position;
            item.transform.parent = tempParent.transform;
            player.GetComponent<FirstPersonController>().pickedUp = true;
        }
    }

    void OnMouseUp() {
        if (player.GetComponent<FirstPersonController>().pickedUp == true)
        {

            // Detach object

            item.GetComponent<Rigidbody>().useGravity = true;
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.transform.parent = null;
            item.transform.position = guide.transform.position;
            player.GetComponent<FirstPersonController>().pickedUp = false;
        }
    }
}