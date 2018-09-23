using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class DevolverScript_Rat : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<Player>().DevolveRat();

            var x = other.GetComponent<CapsuleCollider>();
            //var characterController = GetComponent<CharacterController>();
            //x.height = 1.85f;
            //x.radius = 0.29f;
            //x.direction = 2;
            //x.center = new Vector3(0, 0.24f, 0);

            //characterController.height = 0.1f;

        }
    }
}
