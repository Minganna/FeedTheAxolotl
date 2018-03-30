using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marowak : MonoBehaviour {

	public GameObject Balls;
	private int touch=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < 1.5f) {
			Destroy (gameObject);
			Balls.SetActive (false);
		}
	}

	void OnCollisionStay2D (Collision2D coll)
	{

		if (coll.gameObject.tag == "Platform") {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.right * 9);
		}	
		if (coll.gameObject.tag == "Wall1") {
			if (touch == 0) {
				Balls.SetActive (true);
				touch = touch+1;
			}
		}

	}
}
