using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public float speedH = 2.0f;
    public  float speedV = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        var speed = 0.05f;
        var yAxis = new Vector3(0, 1, 0);
        var xAxis = new Vector3(1, 0, 0);

        var k = new Vector3(
            transform.worldToLocalMatrix.m20,
           0,
            transform.worldToLocalMatrix.m22);
        var i = new Vector3(
            transform.worldToLocalMatrix.m00,
            transform.worldToLocalMatrix.m01,
            transform.worldToLocalMatrix.m02);

        k.Normalize();

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -k * speed;
            //descomentar para ulilizar o efeito dolly zoom 
            //GetComponent<Camera>().fieldOfView--;  
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += k * speed;
            
            //descomentar para ulilizar o efeito dolly zoom 
           //GetComponent<Camera>().fieldOfView++;
        }

        if (Input.GetKey(KeyCode.A)) transform.position += -i * speed ;
        if (Input.GetKey(KeyCode.D)) transform.position += i * speed ;



        if (Input.GetKey(KeyCode.LeftArrow)) transform.Rotate(yAxis, -1, Space.Self);
        if (Input.GetKey(KeyCode.RightArrow)) transform.Rotate(yAxis, 1, Space.Self);
        if (Input.GetKey(KeyCode.UpArrow)) transform.Rotate(xAxis, -1, Space.Self);
        if (Input.GetKey(KeyCode.DownArrow)) transform.Rotate(xAxis, 1, Space.Self);



        //yaw += speedH * Input.GetAxis("Mouse X");
        //pitch -= speedV * Input.GetAxis("Mouse Y");

        //transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);



    }
}
