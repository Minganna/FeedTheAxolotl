using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.GetComponent<Rigidbody> ().AddForce (transform.position += transform.forward * Time.deltaTime * 1);
			//transform.parent.Translate(0, 0, 10 * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate(new Vector3( 0,0,10 * Time.deltaTime));
		}
	}
}
