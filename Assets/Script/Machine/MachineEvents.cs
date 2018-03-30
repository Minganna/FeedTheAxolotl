using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MachineEvents : MonoBehaviour {
	public float BallPower = 1200;
	public float BallPower2 = 1200;
	public Animator Flipper;
	public Animator Flipper2;
	public GameObject Cameras;
	public bool StopAnimation;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < -20) {
			Breakout ();
		}

	}
	void Breakout(){
		SceneManager.LoadScene (3);
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "StartingCube") {
			GetComponent<Rigidbody> ().AddForce (Vector3.forward * 900);
			Cameras.SetActive(true);

		}
		if (coll.gameObject.tag == "Wall1") {
			GetComponent<Rigidbody> ().AddForce (Vector3.right * 600);
			Flipper.SetBool ("IsFlipping", false);
			Flipper2.SetBool ("IsFlipping", false);

		}
		if (coll.gameObject.tag == "Respawn") {
			GetComponent<Rigidbody> ().AddForce (Vector3.right * 800);
			Flipper.SetBool ("IsFlipping", false);
			Flipper2.SetBool ("IsFlipping", false);
		}
		if (coll.gameObject.tag == "Player") {
			GetComponent<Rigidbody> ().AddForce (Vector3.left * 800);
			Flipper.SetBool ("IsFlipping", false);
			Flipper2.SetBool ("IsFlipping", false);
		}

		if (coll.gameObject.tag == "Finish") {
			GetComponent<Rigidbody> ().AddForce (Vector3.forward * 800);
			Flipper.SetBool ("IsFlipping", false);
			Flipper2.SetBool ("IsFlipping", false);
		}

		if (coll.gameObject.tag == "Wall2") {
			GetComponent<Rigidbody> ().AddForce (Vector3.back * 700);
			Flipper.SetBool ("IsFlipping", false);
			Flipper2.SetBool ("IsFlipping", false);
		}
		if (coll.gameObject.tag == "PimballFlip") {
			GetComponent<Rigidbody> ().AddForce (Vector3.forward * 1000);
			GetComponent<Rigidbody> ().AddForce (Vector3.left * 500);
			Flipper.SetBool ("IsFlipping", true);
			StopAnimation = true;
		}
		if (coll.gameObject.tag == "TopWall") {
			GetComponent<Rigidbody> ().AddForce (Vector3.back * BallPower);
			GetComponent<Rigidbody> ().AddForce (Vector3.right * BallPower2);
			Flipper.SetBool ("IsFlipping", false);
			Flipper2.SetBool ("IsFlipping", false);
		}
		if (coll.gameObject.tag == "PimballFlip2") {
			GetComponent<Rigidbody> ().AddForce (Vector3.forward * 1000);
			GetComponent<Rigidbody> ().AddForce (Vector3.right * 500);
			Flipper2.SetBool ("IsFlipping", true);
			StopAnimation = true;

		}
		if (coll.gameObject.tag == "FlipperThings") {
			GetComponent<Rigidbody> ().AddForce (Vector3.back * 1300);
			Flipper.SetBool ("IsFlipping", false);
			Flipper2.SetBool ("IsFlipping", false);
			StopAnimation = false;
		}
	}
}

