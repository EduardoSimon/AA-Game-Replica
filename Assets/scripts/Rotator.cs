using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	[UnityEngine.Header("Angle to rotate per second in degrees")]
    public float speed = 100f; 

	// Update is called once per frame
	void Update () {
        transform.Rotate(0f, 0f, speed * Time.deltaTime); 
	}
}
