﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonkeyCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "DonkeyPlatform1") {
			GetComponent<Rigidbody2D> ().AddForce (Vector3.right * 100);
		}
			if (coll.gameObject.tag == "DonkeyPlatform2") {
			GetComponent<Rigidbody2D> ().AddForce (Vector3.left * 300);
			}

	}
}