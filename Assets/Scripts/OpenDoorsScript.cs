using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorsScript : MonoBehaviour {

    HingeJoint doorHinge;
    JointSpring doorSpring;

    void OnMouseDown()
    {
        doorHinge = gameObject.GetComponent<HingeJoint>();
        doorHinge.useSpring = true;
        doorSpring = doorHinge.spring;
        doorSpring.spring = 0.1f;
        doorSpring.targetPosition = -100;
        doorHinge.spring = doorSpring;
    }
}
