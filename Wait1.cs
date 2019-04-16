// Firdausi Mahmood | 1526546
// MEng Final Year Project
//Callibration (script) is deactivated - sending all values to null. To keep these values active so that they can be used
//in the main exercise, the Wait scripts have been created.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using Senso;
using System.IO;

public class Wait1 : MonoBehaviour {
    //WRITE
    String m_path;

    public static float fistangle, fistangle2, fistangle3, fistangle4, fistangle5, fistangle6, fistangle7, fistangle8, fistangle9;
    public GameObject step1, step2, inst1, inst2;

    // Use this for initialization
    void Start () {
        step1 = GameObject.Find("/Callibration/CalStep1");
        step2 = GameObject.Find("/Callibration/CalStep2");
        inst1 = GameObject.Find("/Callibration/I1");
        inst2 = GameObject.Find("/Callibration/I2");

        m_path = Application.dataPath;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(fistangle);
	}

    public void Wait(float angle, float angle2, float angle3, float angle4, float angle5, float angle6, float angle7, float angle8, float angle9)
    {
        //save angles
        fistangle = angle;
        fistangle2 = angle2;
        fistangle3 = angle3;
        fistangle4 = angle4;
        fistangle5 = angle5;
        fistangle6 = angle6;
        fistangle7 = angle7;
        fistangle8 = angle8;
        fistangle9 = angle9;

        // Debug.Log(fistangle);
    }
}
