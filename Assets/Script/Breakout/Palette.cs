using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palette : MonoBehaviour {

	private bool WallTouched=false;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(WallTouched==false)
			GetComponent<Rigidbody> ().AddForce (Vector3.right * 10);
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "RightWall") {
			GetComponent<Rigidbody> ().AddForce (Vector3.left * 500);
			WallTouched = true;
		}
		if (coll.gameObject.tag == "LeftWall") {
			GetComponent<Rigidbody> ().AddForce (Vector3.right * 500);
		}
	}
}
