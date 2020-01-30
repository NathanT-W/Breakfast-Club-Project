using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItems : MonoBehaviour {

    public GameObject item;
    public GameObject tempParent;
    public Transform guide;
    public GameObject player;

	// Use this for initialization
	void Start () {
        item.GetComponent<Rigidbody>().useGravity = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown() {
        if(player.GetComponent<Character_Movement>().pickedup == false)
        {
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().isKinematic = true;
            item.transform.position = guide.transform.position;
            item.transform.parent = tempParent.transform;
            player.GetComponent<Character_Movement>().pickedup = true;
        }
    }


    void OnMouseUp() {
        if (player.GetComponent<Character_Movement>().pickedup == true)
        {
            item.GetComponent<Rigidbody>().useGravity = true;
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.transform.parent = null;
            item.transform.position = guide.transform.position;
            player.GetComponent<Character_Movement>().pickedup = false;
        }
    }
}
