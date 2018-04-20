using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballappear : MonoBehaviour {
	public GameObject otherBall;
	public Animator Dragon;

	// Use this for initialization
	void Start () {
		StartCoroutine (changeball ());

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator changeball(){

		yield return new WaitForSeconds (0.5f);
		otherBall.SetActive (true);
		yield return new WaitForSeconds (0.1f);
		Dragon.SetBool ("Canwalk", true);
		Destroy (gameObject);
	}
}
