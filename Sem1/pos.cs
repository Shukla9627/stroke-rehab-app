using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pos_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
          
    }
	
	// Update is called once per frame
	void Update () {
        // Create position vector
        Vector3 pos;
        pos = transform.position;

        // Print bone name and position
        Debug.Log(transform.name + "\tPostition: " + pos);
    }
}
