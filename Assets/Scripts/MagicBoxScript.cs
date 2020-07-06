using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBoxScript : MonoBehaviour {

    public GameObject milkyTeaCup;
    public GameObject nonMilkyTeaCup;
    public GameObject milkyTeaMug;
    public GameObject nonMilkyTeaMug;

    Vector3 spawnPoint = new Vector3(2.569f, 1.144f, -7.289f);
    Quaternion spawnRotation = new Quaternion(0f, 0f, 0f, 0f);

    public GameObject guide;

    void OnTriggerEnter(Collider col)
    {
        GameObject temp = guide;
        switch (col.gameObject.tag)
        {
            case "EmptyCup":
               temp = Instantiate(nonMilkyTeaCup, spawnPoint, spawnRotation);
                break;
            case "EmptyMug":
                temp = Instantiate(nonMilkyTeaMug, spawnPoint, spawnRotation);
                break;
            case "MilkCup":
                temp = Instantiate(milkyTeaCup, spawnPoint, spawnRotation);
                break;
            case "MilkMug":
                temp = Instantiate(milkyTeaMug, spawnPoint, spawnRotation);
                break;
        }

        temp.GetComponent<PickupItems>().guide = guide.transform;
        temp.GetComponent<PickupItems>().tempParent = guide;

        Destroy(col.gameObject);
    }    
}
