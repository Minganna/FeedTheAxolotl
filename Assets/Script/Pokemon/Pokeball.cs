using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokeball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "GlassJoe") {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.right * 1500);
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 500);
		}

		}
}
