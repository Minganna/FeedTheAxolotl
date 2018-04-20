using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KirbyStar : MonoBehaviour {
	public GameObject Dedede;
	public GameObject stopper;
	public GameObject damage;
	public int Hit=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y > 70) {
			SceneManager.LoadScene ("TheLegendOfZelda");
		}
		if (Hit == 1) {
			GetComponent<Rigidbody> ().AddForce (Vector3.up * 500);
			GetComponent<Rigidbody> ().AddForce (Vector3.left * 500);
			damage.SetActive (true);
		}
		if (Hit == 0) {
			GetComponent<Rigidbody> ().AddForce (Vector3.right * 100);
		}
	}

	void OnCollisionStay (Collision coll)
	{
		if (coll.gameObject.tag == "Respawn") {
			Hit = 1;
			stopper.SetActive (false);
			Destroy (Dedede);



		}
	}
}
