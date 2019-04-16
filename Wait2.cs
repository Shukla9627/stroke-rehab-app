// Firdausi Mahmood | 1526546
// MEng Final Year Project
//Callibration (script) is deactivated - sending all values to null. To keep these values active so that they can be used
//in the main exercise, the Wait scripts have been created.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wait2 : MonoBehaviour {

    public static float midangle, midangle2, midangle3, midangle4, midangle5, midangle6, midangle7, midangle8, midangle9;
    public GameObject step1, step2, inst1, inst2;

    // Use this for initialization
    void Start()
    {
        step1 = GameObject.Find("/Callibration/CalStep1");
        step2 = GameObject.Find("/Callibration/CalStep2");
        inst1 = GameObject.Find("/Callibration/I1");
        inst2 = GameObject.Find("/Callibration/I2");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Wait(float angle, float angle2, float angle3, float angle4, float angle5, float angle6, float angle7, float angle8, float angle9)
    {
        //save angles
        midangle = angle;
        midangle2 = angle2;
        midangle3 = angle3;
        midangle4 = angle4;
        midangle5 = angle5;
        midangle6 = angle6;
        midangle7 = angle7;
        midangle8 = angle8;
        midangle9 = angle9;
    }
}
