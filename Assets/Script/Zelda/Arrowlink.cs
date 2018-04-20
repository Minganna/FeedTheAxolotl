using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arrowlink : MonoBehaviour {
	public GameObject Eyes1;
	public GameObject Eyes2;
	public GameObject Camera1;
	public GameObject Camera2;
	public GameObject Text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ().AddForce (Vector3.left * 5);
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "Player") {
			GetComponent<Rigidbody> ().AddForce (Vector3.up * 1000);
		}
		if (coll.gameObject.tag == "Finish") {
			StartCoroutine (closeeye ());

		
		}
			
	}

	IEnumerator closeeye (){
		yield return new WaitForSeconds (0.5f);
		Eyes1.SetActive (true);
		Eyes2.SetActive (false);
		yield return new WaitForSeconds (0.5f);
		Camera1.SetActive (false);
		Camera2.SetActive (true);
		Text.SetActive (true);

		yield return new WaitForSeconds (1f);
		SceneManager.LoadScene (12);
		}	
}
