using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MyReplay : MonoBehaviour {
    private const int bufferFrames = 100;
    private MyKeyFrame[] keyFrames = new MyKeyFrame[bufferFrames];
    private Rigidbody rigidBody;
    private GameManager gameManager;
    // Use this for initialization
    void Start() {
        rigidBody = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.recording == true)
        {
        Record();
        }else
        {
            PlayBack();
        }

    }

    private void Record()
    {
        rigidBody.isKinematic = false;
        int frame = Time.frameCount % bufferFrames;
        Debug.Log("Wrinting frame " + frame);
        keyFrames[frame] = new MyKeyFrame(Time.time, transform.position, transform.rotation);
    }
    void PlayBack()
    {
        rigidBody.isKinematic = true;
        int frame = Time.frameCount % bufferFrames;
        Debug.Log("Reading frame " + frame);
        transform.position = keyFrames[frame].pos;
        transform.rotation = keyFrames[frame].rot;
    }
}
/// <summary>
/// A structue for storing time, postion and rotation
/// </summary>
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
