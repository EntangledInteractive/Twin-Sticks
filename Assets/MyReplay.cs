using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyReplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
public class MyKeyFrame
{
    public float myTime;
    public  Vector3 pos;
    public  Quaternion rot;

    public MyKeyFrame(float atime, Vector3 apos,Quaternion arot)
    {
        myTime = atime;
        pos = apos;
        rot = arot;
    }
}
