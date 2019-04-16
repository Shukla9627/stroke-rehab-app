// Firdausi Mahmood | 1526546
// MEng Final Year Project
//Callibration (script) is deactivated - sending all values to null. To keep these values active so that they can be used
//in the main exercise, the Wait scripts have been created.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wait3 : MonoBehaviour {

    public static float wideangle, wideangle2, wideangle3, wideangle4, wideangle5, wideangle6, wideangle7, wideangle8, wideangle9;
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
        wideangle = angle;
        wideangle2 = angle2;
        wideangle3 = angle3;
        wideangle4 = angle4;
        wideangle5 = angle5;
        wideangle6 = angle6;
        wideangle7 = angle7;
        wideangle8 = angle8;
        wideangle9 = angle9;
    }
}
