using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHitGlassJoe : MonoBehaviour {
	public Animator GlassJoe;
	public GameObject Stopper;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "GlassJoe") {
			GlassJoe.SetBool ("Hit", true);
			Stopper.SetActive (true);
		}
	}

		}



