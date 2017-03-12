using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeriveringsRegler : MonoBehaviour {

    public float time1 = 5, time2 =  0;

    float placeholder;


	void Start () {
        AverageSpeed();
        CurrentSpeed();
        Acceleration();
	}
	
	// Update is called once per frame
    float Function(float time)
    {
        time = 15 * time + 0.8f * (time * time);
        Debug.Log("distance: " + time + " meters");
        return time;
    }

    void AverageSpeed()
    {
        float avarageSpeed = (Function(time1) - Function(time2)) / time1 - time2;
        Debug.Log("AvarageSpeed: " + avarageSpeed + "m/s");
    }

    void CurrentSpeed()
    {
        float currentVelocity = 15 + 0.8f * (2 * time1);
        Debug.Log("currentSpeed: " + currentVelocity + " m/s");
    }

    void Acceleration()
    {
        float currentAcceleration = 0.8f * 2;
        Debug.Log("currentAcceleration: " + currentAcceleration + " m/s2");
    }
}
