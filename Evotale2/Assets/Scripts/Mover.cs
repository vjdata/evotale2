using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    private bool hasPushed = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (!hasPushed)
	    {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(100, 200, 100));
	        hasPushed = true;
	    }
	}
}
