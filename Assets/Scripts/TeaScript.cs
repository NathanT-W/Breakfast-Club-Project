using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaScript : MonoBehaviour {

    public Mesh milkCupMesh;
    public Material milkCup;
    public Mesh finishedCupMesh;
    public Material finishedCup;
    public Mesh milkMugMesh;
    public Material milkMug;
    public Mesh finishedMugMesh;
    public Material finishedMug;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Milk")
        {
            switch (gameObject.tag)
            {

                // IF cup is empty, fill it with milk. If it's filled with tea, change it to finished tea.

                case "EmptyCup":
                    gameObject.GetComponent<MeshRenderer>().material = milkCup;
                    gameObject.GetComponent<MeshFilter>().mesh = milkCupMesh;
                    gameObject.tag = "MilkCup";
                    break;
                case "EmptyMug":
                    gameObject.GetComponent<MeshRenderer>().material = milkMug;
                    gameObject.GetComponent<MeshFilter>().mesh = milkMugMesh;
                    gameObject.tag = "MilkMug";
                    break;
                case "TeaMug":
                    gameObject.GetComponent<MeshRenderer>().material = finishedMug;
                    gameObject.GetComponent<MeshFilter>().mesh = finishedMugMesh;
                    gameObject.tag = "FinishedMug";
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
