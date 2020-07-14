using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaScript : MonoBehaviour {

    public Mesh milkCupMesh;
    public Material milkCup;
    public Mesh finishedCupMesh;
    public Material finishedCup;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Milk")
        {
            switch (gameObject.tag)
            {
                case "EmptyCup":
                    gameObject.GetComponent<MeshRenderer>().material = milkCup;
                    gameObject.GetComponent<MeshFilter>().mesh = milkCupMesh;
                    gameObject.tag = "MilkCup";
                    break;
                case "EmptyMug":
                    break;
                case "TeaMug":
                    break;
                case "TeaCup":
                    gameObject.GetComponent<MeshRenderer>().material = finishedCup;
                    gameObject.GetComponent<MeshFilter>().mesh = finishedCupMesh;
                    gameObject.tag = "FinishedCup";
                    break;
            }
        }

    }


}
