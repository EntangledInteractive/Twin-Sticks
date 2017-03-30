using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {
    public bool recording = true;
  
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (CrossPlatformInputManager.GetButton("Fire1"))
        {
            recording = false;

        }
        else
        {
            recording = true;
        }
    }
    //public void IsRecording()
    //{
    //    if(recording == true)
    //    {
    //        recording = false;
    //    }else if(recording == false)
    //    {
    //        recording = true;
    //    }
    //}
}
