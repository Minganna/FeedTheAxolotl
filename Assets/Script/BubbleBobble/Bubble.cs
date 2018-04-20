using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bubble : MonoBehaviour {
	public GameObject Pokeball;
	public GameObject Pokeball2;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().AddForce (Vector3.right * 800);
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "RightWall") {
			Pokeball.SetActive (false);
			Pokeball2.SetActive (true);
			GetComponent<Rigidbody> ().AddForce (Vector3.up * 800);
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y > 25) {
			SceneManager.LoadScene ("Kirby");
	}
}
}
