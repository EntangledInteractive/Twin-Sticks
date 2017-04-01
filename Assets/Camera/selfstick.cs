using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfstick : MonoBehaviour {
    public float panSpeed = 10f;

    private GameObject player;
    private Vector3 armRotation;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        armRotation = transform.rotation.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
        armRotation.y += Input.GetAxis("Rhoriz")* panSpeed;
        armRotation.x += Input.GetAxis("Rvert") * panSpeed;
        transform.position = player.transform.position;
        transform.rotation = Quaternion.Euler(armRotation);
	}
}
