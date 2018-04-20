using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twodbubble : MonoBehaviour {
	public GameObject otherpokeball;
	public GameObject Text;

	// Use this for initialization
	void Start () {
		StartCoroutine (AnimationEnding ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator AnimationEnding(){

		yield return new WaitForSeconds (1.4f);
		otherpokeball.SetActive (true);
		Text.SetActive (false);
		yield return new WaitForSeconds (0.2f);
		Destroy (gameObject);
	
	}

}
