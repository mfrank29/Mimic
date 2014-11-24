﻿using UnityEngine;
using System.Collections;

public class Trail : MonoBehaviour 
{
    Vector3 lastPos, actualPos;

	// Use this for initialization
	void Awake () 
    {
        lastPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
    {

        if (lastPos != actualPos)
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, transform.rotation.eulerAngles.z + (Vector3.Angle(lastPos, actualPos))));
        lastPos = actualPos;
	}

	public void newPos(Vector3 newPos ){

		newPos.z = +10;
		transform.position = actualPos;
	}

	void OnMouseDrag(){

		Debug.Log("drag");
		actualPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		actualPos.z += 10;
		transform.position = actualPos;
	}
}
