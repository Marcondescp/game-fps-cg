using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var moveUp = new Vector3(0,0,1);
        var moveDown = new Vector3(0,0,-1);
        var moveLeft = new Vector3(-1,0,0);
        var moveRight = new Vector3(1,0,0);

        float velocity = 0.2f;

        var displacement = new Vector3(0,0,0);

       
        if (Input.GetKey(KeyCode.W))
        {
            displacement += moveUp ;
        }

        if (Input.GetKey(KeyCode.A))
        {
           displacement += moveLeft;
        }

        if (Input.GetKey(KeyCode.S))
        {
            displacement += moveDown;
        }

        if (Input.GetKey(KeyCode.D))
        {
           displacement += moveRight;
        }

        displacement.Normalize();

        transform.position += displacement * velocity;

    }
}
