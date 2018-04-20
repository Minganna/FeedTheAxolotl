using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarZelda : MonoBehaviour {
	public int startingpoint=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (startingpoint == 0){
			GetComponent<Rigidbody> ().AddForce (Vector3.up * 50);
		GetComponent<Rigidbody> ().AddForce (Vector3.left * 50);
	}
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "Respawn") {
			startingpoint = 1;
		}


		}
}
