using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeBallMove : MonoBehaviour {
	public GameObject otherwall;
	public Animator Dragon;
	public GameObject Drago;
	public GameObject OldDragon;
	public GameObject Enemy;
	public GameObject particles;
	public Animator Enemyanimator;
	public GameObject Bubble;
	public GameObject Bubble2;
		public float speed = 100f;

	void Start () {
		GetComponent<Rigidbody> ().AddForce (Vector3.up * 500);
		GetComponent<Rigidbody> ().AddForce (Vector3.right * 1000);

	}

		void Update ()
		{
		transform.Rotate(new Vector3( speed * Time.deltaTime,0));
		}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "RightWall") {
			otherwall.SetActive (true);
			StartCoroutine (bubble ());
			}
	}

	IEnumerator bubble(){
		Dragon.SetBool ("Bubble", true);
		yield return new WaitForSeconds (0.2f);
		Drago.SetActive (true);
		OldDragon.SetActive (false);
		yield return new WaitForSeconds (0.55f);
		particles.SetActive (true);
		Enemyanimator.SetBool ("Disappearing", true);
		yield return new WaitForSeconds (0.6f);
		Destroy (Enemy);
		Bubble.SetActive (true);
		yield return new WaitForSeconds (0.4f);
		Bubble.SetActive (false);
		yield return new WaitForSeconds (0.1f);
		Bubble2.SetActive (true);



	}
	}


