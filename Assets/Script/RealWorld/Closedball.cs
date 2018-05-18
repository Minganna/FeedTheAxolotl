using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closedball : MonoBehaviour {

	public GameObject[] chain= new GameObject[39];
	int numberChains=41;
	public GameObject Object3;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().AddForce (Vector3.back * 500);
		StartCoroutine (chains ());
		Object3.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator chains ()
	{
		
		for (int i = 0; i < numberChains; i++) {
			yield return new WaitForSeconds (0.1f);
			Destroy(chain [i]);
		}

	}

}
