using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    public GameObject Ethan;
    public GameObject LeOgre;
    public GameObject Rat;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var isJumping = CrossPlatformInputManager.GetButtonDown("Jump");
	    if (isJumping)
	    {
	        var s = GetComponent<AudioSource>();
            s.Play();
	    }
    }

    public void Devolve()
    {
        if (Ethan.activeSelf)
        {
            this.Ethan.SetActive(false);
            this.LeOgre.SetActive(true);
        }
    }

    public void DevolveRat()
    {
        if (LeOgre.activeSelf)
        {
            this.LeOgre.SetActive(false);
            this.Rat.SetActive(true);
        }
    }
}
