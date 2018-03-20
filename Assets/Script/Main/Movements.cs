using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movements : MonoBehaviour {

	public bool roller=false;
	public float playerJumpPower=50;
	public bool changecamera=false;
	public GameObject Cage1;
	public GameObject Cage2;
	public Animator animationlogo;
	public GameObject Logo;


	void OnCollisionStay2D(Collision2D coll){

		if (coll.gameObject.tag == "Platform")
			roller = true;
		if (coll.gameObject.tag == "ball") {
			changecamera = true;
		}
			if (coll.gameObject.tag == "Cage") {
			Cage1.SetActive(true);
			Cage2.SetActive(true);
			animationlogo.SetBool ("IsCaged", true);
			StartCoroutine( Fadeoff ());
			}
			
	}

	IEnumerator Fadeoff()
	{
		yield return new WaitForSeconds (1f);
		gameObject.SetActive(false);
		Logo.SetActive (true);


	}





	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (roller == true) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.right * playerJumpPower);
		}
		
	}
}
