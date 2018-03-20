using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallBreakout : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < -35) {
			Donkey ();
		}

	}
	void Donkey(){
		SceneManager.LoadScene (4);
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "Block") {
			GetComponent<Rigidbody> ().AddForce (Vector3.up * 200);
			Destroy (coll.gameObject);
		}
		if (coll.gameObject.tag == "Palette") {
			GetComponent<Rigidbody> ().AddForce (Vector3.up * 2000);

		}
	}
}
