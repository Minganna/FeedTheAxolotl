using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxolotlBehaviour : MonoBehaviour {
	public GameObject Axolotl;
	public Rigidbody Axolotlrb;
	public GameObject Camera1;
	public GameObject Camera2;
	public GameObject Canvas;

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
			Camera1.SetActive (false);
			Camera2.SetActive (true);
			StartCoroutine (Ending ());

		}
	
	}

	IEnumerator Ending()
	{
		yield return new WaitForSeconds (3f);
		Canvas.SetActive (true);
	}
}
