using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour {

    public float initialVelocity;
    public float acceleration;
    float currentVelocity;


	// Use this for initialization
	void Start () {
        currentVelocity = initialVelocity;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(Time.fixedTime < Timer.predictedTime)
        {
            currentVelocity += acceleration * Time.deltaTime;
            transform.Translate(Vector3.forward * currentVelocity * Time.deltaTime);
        }
	}
}
