using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript : MonoBehaviour {

    public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 currentRotate = new Vector3();
        currentRotate = Player.transform.rotation.eulerAngles;

        if (Input.GetAxis("Mouse X") < 0)
        {
            //Left

            Vector3 newRotateVector = new Vector3(currentRotate.x, currentRotate.y - 3,0);
            Quaternion newRotate = new Quaternion();
            newRotate.eulerAngles = newRotateVector;

            transform.rotation = newRotate;
        }
        if(Input.GetAxis("Mouse X") > 0)
        {
            //Right
            
            Vector3 newRotateVector = new Vector3(currentRotate.x, currentRotate.y + 3, 0);
            Quaternion newRotate = new Quaternion();
            newRotate.eulerAngles = newRotateVector;

            transform.rotation = newRotate;
        }

        if(Input.GetAxis("Mouse Y") < 0)
        {
            // Down

                Vector3 newRotateVector = new Vector3(currentRotate.x + 3, currentRotate.y, 0);
                Quaternion newRotate = new Quaternion();

                newRotateVector.x = Mathf.Clamp(newRotateVector.x, 0, 90f);

                newRotate.eulerAngles = newRotateVector;

                transform.rotation = newRotate;

        }
        if(Input.GetAxis("Mouse Y") > 0)
        {
            // Up

                Vector3 newRotateVector = new Vector3(currentRotate.x - 3, currentRotate.y, 0);
                Quaternion newRotate = new Quaternion();

                newRotateVector.x = Mathf.Clamp(newRotateVector.x, 0, 90f);
                newRotate.eulerAngles = newRotateVector;

                transform.rotation = newRotate;
            
        }
	}
}
