using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube : MonoBehaviour {
	public GameObject GB2;
	public GameObject GB3;
	public GameObject Object2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "ball") {
			GB3.SetActive (true);
			gameObject.SetActive (false);
			GB2.SetActive (false);
			GB3.SetActive (true);
			Object2.SetActive (false);

		}
	}
}
