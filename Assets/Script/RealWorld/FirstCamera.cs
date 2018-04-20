using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCamera : MonoBehaviour {
	public GameObject camera2;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().AddForce (Vector3.forward *3000);
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < 40) {
			gameObject.SetActive (false);
			camera2.SetActive (true);
		}
	}
}
