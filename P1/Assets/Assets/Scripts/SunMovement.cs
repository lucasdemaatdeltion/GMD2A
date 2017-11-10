using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMovement : MonoBehaviour {

    public float sunmovementSpeed = 60f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xAngle = Time.fixedDeltaTime * sunmovementSpeed / 360;
        transform.Rotate(xAngle,0,0);
		
	}
}
