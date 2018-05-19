using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealBall : MonoBehaviour {
	public GameObject cilindercamera; 
	public GameObject Ness1;
	public GameObject Ness2;
	public GameObject Object1;
	public AudioClip RollingSound;
	private AudioSource source;
	public AudioClip Domino;

	// Use this for initialization
	void Start () {
		source = GetComponent <AudioSource>();
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
		source.Play ();
		GetComponent<Rigidbody> ().AddForce (Vector3.forward *20);
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "StartingCube") {
			GetComponent<Rigidbody> ().AddForce (Vector3.right * 100);

		}
		if (coll.gameObject.tag == "GlassJoe") {
			source.Stop ();
			StartCoroutine (WaitforDominoes ());
			source.PlayOneShot (Domino);

		}
	}


	IEnumerator WaitforDominoes()
	{
		yield return new WaitForSeconds (3f);
		Object1.SetActive (false);
	}
}
