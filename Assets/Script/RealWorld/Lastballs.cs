using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lastballs : MonoBehaviour {
	public GameObject Camera1;
	public GameObject Camera2;
	public GameObject Scizzor;
	public GameObject Object6;
	public GameObject WormsStopper;
	public AudioClip RollingSound;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent <AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ().AddForce(Vector3.right * 20);
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "GlassJoe") {
			Camera1.SetActive (false);
			Camera2.SetActive (true);

		}
		else if(coll.gameObject.tag=="Respawn"){
			Destroy (coll.collider.gameObject);
			source.Stop ();
			Scizzor.SetActive (true);
			StartCoroutine (Ending ());
	}
}

	IEnumerator Ending(){
		yield return new WaitForSeconds (1f);
		Camera2.SetActive (false);
		Object6.SetActive (false);
		Camera1.SetActive (true);
		yield return new WaitForSeconds (0.1f);
		Destroy (WormsStopper);
	}
}


