using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisStart : MonoBehaviour {
	public GameObject Rope1;
	public GameObject Rope2;
	public Rigidbody TetrisPiece;

	// Use this for initialization
	void Start () {
		StartCoroutine (StartTetris ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator	StartTetris (){
		yield return new WaitForSeconds (2f);
		Rope1.SetActive (false);
		yield return new WaitForSeconds (2f);
		Rope2.SetActive (false);
		TetrisPiece.isKinematic =false;

	}
}
