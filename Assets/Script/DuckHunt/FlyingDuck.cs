using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyingDuck : MonoBehaviour {

	public GameObject Shoot;
	public GameObject Target;
	public GameObject Dog;
	public AudioClip ShootSound;
	private AudioSource source;
	// Use this for initialization
	void Start () {
		source = GetComponent <AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "SlideFly") {
			GetComponent<Rigidbody2D> ().AddForce (Vector3.left * 500);
		}
}

	void OnTriggerEnter2D (Collider2D other)
	{
		source.PlayOneShot (ShootSound);
		Shoot.SetActive (true);

		StartCoroutine(Shootstop());
	}

	IEnumerator Shootstop(){
		yield return new WaitForSeconds (0.1f);
		Shoot.SetActive (false);
		Target.SetActive (false);
		Dog.SetActive (true);
		yield return new WaitForSeconds (2f);
		SceneManager.LoadScene ("Pokemon");
	}
	   
}
