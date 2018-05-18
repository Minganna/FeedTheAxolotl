using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealBall2 : MonoBehaviour {

	public GameObject closedball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "GlassJoe") {
			GetComponent<Rigidbody> ().AddForce (Vector3.right * 500);

		}
		if (coll.gameObject.tag == "Respawn") {
			gameObject.SetActive (false);
			coll.gameObject.SetActive (false);
			closedball.SetActive (true);

		}
	}
}
