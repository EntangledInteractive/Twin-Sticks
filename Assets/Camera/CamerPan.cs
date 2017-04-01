using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerPan : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print("Rhoriz " + Input.GetAxis("Rhoriz"));
       // print("Rvert " + Input.GetAxis("Rvert"));
	}
}
