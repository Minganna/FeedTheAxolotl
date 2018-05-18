using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealBall : MonoBehaviour {
	public GameObject cilindercamera; 
	public GameObject Ness1;
	public GameObject Ness2;
	public GameObject Object1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Ness1.activeSelf && cilindercamera.transform.position.y < 40) {
			StartCoroutine (NintendoOpener ());


		}
			
			
	}

	IEnumerator NintendoOpener ()
	{
		yield return new WaitForSeconds (1f);
		Ness1.SetActive (false);
		Ness2.SetActive (true);
		GetComponent<Rigidbody> ().AddForce (Vector3.forward *20);
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "StartingCube") {
			GetComponent<Rigidbody> ().AddForce (Vector3.right * 100);

		}
		if (coll.gameObject.tag == "GlassJoe") {
			Object1.SetActive (false);
		}
	}

}
