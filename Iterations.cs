// Firdausi Mahmood | 1526546
// MEng Final Year Project
// Increments iteration counter when activated

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class Iterations : MonoBehaviour {

    public static int StepCounter;
    public Text Iteration;

    // Use this for initialization
    void Start () {
        Iteration = GetComponent<Text>();
        StepCounter = 0;
    }
	
	// Update is called once per frame
	void OnEnable () {
      //increment step counter
      StepCounter++;

    }
}
