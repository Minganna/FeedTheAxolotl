using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxolotlBehaviour : MonoBehaviour {
	public GameObject Axolotl;
	public Rigidbody Axolotlrb;

	// Use this for initialization
	void Start () {
		Axolotlrb= Axolotl.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "Block") {
			Axolotlrb.AddForce (Vector3.back * 100);
			Axolotlrb.AddForce (Vector3.left * 100);
		}
	
	}
}
