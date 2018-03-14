using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour {

	public bool roller=false;
	public float playerJumpPower=1000;
	public bool changecamera=false;
	public GameObject Cage1;
	public GameObject Cage2;
	public Animator animationlogo;

	void OnCollisionStay2D(Collision2D coll){

		if (coll.gameObject.tag == "Platform")
			roller = true;
		if (coll.gameObject.tag == "ball") {
			changecamera = true;
		}
			if (coll.gameObject.tag == "Cage") {
			Cage1.SetActive(true);
			Cage2.SetActive(true);
			animationlogo.SetBool ("IsCaged", true);
			}
			
	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (roller == true) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.right * playerJumpPower);
		}
		
	}
}
