﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var moveUp = new Vector3(0, 0, 1);
        var moveDown = new Vector3(0, 0, -1);
        var moveLeft = new Vector3(-1, 0, 0);
        var moveRight = new Vector3(1, 0, 0);

        float velocity = 0.2f;

        var displacement = new Vector3(0, 0, 0);


        if (Input.GetKey(KeyCode.UpArrow))
        {
            displacement += moveUp;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            displacement += moveLeft;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            displacement += moveDown;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            displacement += moveRight;
        }

        displacement.Normalize();

        transform.position += displacement * velocity;
    }
}
