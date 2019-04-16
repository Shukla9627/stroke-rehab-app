// Firdausi Mahmood | 1526546
// MEng Final Year Project
// Display iteration value on screen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IterationCount : MonoBehaviour {

    public Text Iteration;
    public static int counter;

	// Use this for initialization
	void Start () {
        Iteration = GetComponent<Text>();
        counter = 0;
    }
	
	// Update is called once per frame
	void Update () {
        //calls iteration value and displays it on the screen
        counter = Iterations.StepCounter;
        Iteration.text = "Iterations Complete: " + counter.ToString();
    }


}
