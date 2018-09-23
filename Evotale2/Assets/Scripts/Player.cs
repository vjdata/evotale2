using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
		
	}

    public void Devolve()
    {
        this.Ethan.SetActive(false);
        this.LeOgre.SetActive(true);
    }

    public void DevolveRat()
    {
        this.LeOgre.SetActive(false);
        this.Rat.SetActive(true);
    }
}
