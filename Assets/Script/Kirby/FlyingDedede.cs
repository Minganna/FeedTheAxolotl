using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingDedede : MonoBehaviour {
	public GameObject CrushDedede;
	public GameObject Dededestopper;

	public int Flying=10;
	public int i=0;

	// Use this for initialization
	void Start () {
		Fly ();
	}
	
	// Update is called once per frame
	void Update () {
		

	}
	void Fly(){
		StartCoroutine(Flyroutine ());
	}

	IEnumerator Flyroutine()
	{
		for ( i = 0; i < Flying; ) {
			GetComponent<Rigidbody> ().AddForce (Vector3.right *250);
			yield return new WaitForSeconds (1f);
			GetComponent<Rigidbody> ().AddForce (Vector3.up *900);

			i++;
		}
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "Block") {
			CrushDedede.SetActive (true);
			Dededestopper.SetActive (true);
			gameObject.SetActive (false);

		}
		}
}
