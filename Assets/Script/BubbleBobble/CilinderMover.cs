using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilinderMover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			GetComponent<Rigidbody> ().AddForce (Vector3.right * 10);

			}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody> ().AddForce (Vector3.left * 10);
	}
		if (Input.GetKey (KeyCode.UpArrow)) {
			GetComponent<Rigidbody> ().AddForce (Vector3.up * 10);
		}
		if (Input.GetKey ("down" )) {
			GetComponent<Rigidbody> ().AddForce (Vector3.down * 10);
		}
}
}
