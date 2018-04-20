using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleKirby : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < 1) {
			GetComponent<Rigidbody> ().AddForce (Vector3.up *20);
		} 
		else if(gameObject.transform.position.y>1)
		{GetComponent<Rigidbody> ().AddForce (Vector3.down * 6);
		}
	}
}
