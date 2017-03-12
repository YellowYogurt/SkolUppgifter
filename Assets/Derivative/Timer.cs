using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    public static float predictedTime;
    public Motor objectA, objectB;

    public Camera viewCamera;

    public float timeStep = 0.01f;
	void Start () {

        Time.fixedDeltaTime = timeStep;
        
        float h = objectA.transform.position.z - objectB.transform.position.z;

        float a = objectB.acceleration - objectA.acceleration;
        float b = 2 * (objectB.initialVelocity - objectA.initialVelocity);
        float c = -2 * h;

        predictedTime = (-b + Mathf.Sqrt(b * b - 4 * a * c)) / (2 * a);
        print(predictedTime);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        viewCamera.transform.LookAt(objectB.transform);
    }
}
