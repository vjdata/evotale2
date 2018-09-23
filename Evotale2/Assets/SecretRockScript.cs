using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Gaia.GXC.Opsive;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class SecretRockScript : MonoBehaviour
{

    public GameObject ConglaturationText;

    public GameObject AwesomeEffect;

    public GameObject EffectPos;
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
            //var ethan = other.gameObject.FindChildrenByTag("Ethan").FirstOrDefault();
            //var ogre = other.gameObject.FindChildrenByTag("Ogre").FirstOrDefault();


            var s = other.GetComponent<ThirdPersonCharacter>();
            s.m_JumpPower = 30f;
            ConglaturationText.SetActive(true);
            Instantiate(AwesomeEffect, EffectPos.transform.position, EffectPos.transform.rotation);
            //s.Move(new Vector3(20, 30, 50), false, true );
        }
    }
}
