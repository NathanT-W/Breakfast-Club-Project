using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyonLoad : MonoBehaviour {

	// Use this for initialization
	void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
