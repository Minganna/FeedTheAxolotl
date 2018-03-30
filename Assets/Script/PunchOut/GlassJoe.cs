using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlassJoe : MonoBehaviour {

	public Animator Joe;
	public GameObject Duck;
	public Animator Duck2;
	public GameObject Cube;
	// Use this for initialization
	void Start () {
		StartCoroutine (GlassJoeStopper ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator GlassJoeStopper(){

		yield return new WaitForSeconds (2.7f);
		Joe.SetBool ("Hit", false);
		yield return new WaitForSeconds (0.5f);
		Duck.SetActive (true);
		Cube.SetActive (false);
		yield return new WaitForSeconds (2f);
		Duck2.SetBool ("Fly", true);

		yield return new WaitForSeconds (0.4f);
		SceneManager.LoadScene ("DuckHunt");

	}


}
