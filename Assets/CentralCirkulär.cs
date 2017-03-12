using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralCirkulär : MonoBehaviour {

    Rigidbody rb;
    public Transform center;
    //Konstana Farten i cirkulär rörelse
    private float v;
    //Tid för ett omlopp;
    public float T;
    //Antalet Varv per sekund
    [SerializeField]
    float f;
    //Anger hur mycket den vrider sig per tidsenhet rad/s
    private float W;
    //omkrets
    private float o;

    public float radius;

	void Start ()
    {
        f = 1 / T;
        rb = GetComponent<Rigidbody>();
        print(CentralCirkulärRörelse() + " i CentripitalAcceleration");
	}
	
    float CentralCirkulärRörelse()
    {
        float v;
        float o = 2 * Mathf.PI * radius;
        W = 2 * (Mathf.PI) / T;
        v = W * radius;

        //CentriptalAcceleration: Ac
        float ac = (v * v) / radius;

        //CentripitalKraft: Fc = Ac * m(massa)
        return ac;
    }

	void Update ()
    {
        rb.AddForce()
	}
}
