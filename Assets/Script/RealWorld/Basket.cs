using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour {
	private bool stop=false;
	private bool stop2=false;
	public bool StartUp=false;
	private Rigidbody rb;
	public GameObject[] Balls;
	public GameObject Object5;

	
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody> ();

			

	}
	
	// Update is called once per frame
	void Update () {
		if (StartUp == true) {
			 if (stop == false) {
				rb.AddForce (Vector3.up * 10);
			} else if (stop2 == false) {
				StartCoroutine (stops ());

			}
		}
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "Link") {
			stop = true;


		}

	}

	IEnumerator stops ()
	{

		stop2 = true;
			yield return new WaitForSeconds (0.7f);
		rb.isKinematic = true;
		Destroy (Balls [0]);
		Destroy (Balls [1]);
		Balls [2].SetActive (true);
		Balls [3].SetActive (true);
		yield return new WaitForSeconds (1.2f);
		Destroy(Balls [2]);
		Destroy(Balls [3]);
		Balls [4].SetActive (true);
		Balls [5].SetActive (true);
		Object5.SetActive(false);
	}

}
