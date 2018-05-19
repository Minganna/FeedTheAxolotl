using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealBall2 : MonoBehaviour {

	public GameObject closedball;
	public AudioClip RollingSound;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent <AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "GlassJoe") {
			GetComponent<Rigidbody> ().AddForce (Vector3.right * 500);
			source.Play ();

		}
		if (coll.gameObject.tag == "Respawn") {
			gameObject.SetActive (false);
			coll.gameObject.SetActive (false);
			closedball.SetActive (true);

		}
	}
}
