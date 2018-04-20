using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kirbymovements : MonoBehaviour {
	public GameObject Kirbysteady;
	public GameObject Kirbyrunningright;
	public GameObject Kirbyrunningleft;
	public GameObject Bubble;
	public Rigidbody rb;
	public GameObject KirbyInhale;
	public GameObject Particles;
	public Rigidbody Bubblerb;
	public GameObject Wall;
	public GameObject KingDededeidle;
	public GameObject FlyingDedede;
	public GameObject KirbyFull;
	public GameObject KirbyInhale2;
	public GameObject Star;
	public GameObject Crunchdedede;
	public GameObject Idlededede2;

	// Use this for initialization
	void Start () {
		rb= Kirbyrunningleft.GetComponent<Rigidbody>();
		Bubblerb=Bubble.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (KingDededeidle.activeSelf && Bubble.transform.position.y > 1) {
			Kirbysteady.SetActive (false);
			Kirbyrunningleft.SetActive (true);
			KingDededeidle.SetActive (false);
			FlyingDedede.SetActive (true);
		} 
		if (Kirbyrunningleft.transform.position.x < -80) {
			Kirbyrunningleft.SetActive (false);
			KirbyInhale.SetActive (true);
			Wall.SetActive (false);
			Particles.SetActive (true);

		} 

		if (Kirbyrunningleft.activeSelf) {
			rb.AddForce (Vector3.left *10);
		}
		if (KirbyInhale.activeSelf && Bubble.transform.position.y <-2) {
			Bubblerb.AddForce (Vector3.right * 10);
		}
		if (Idlededede2!=null &&Bubble.transform.position.x > -60) {
			Bubble.SetActive (false);
			KirbyInhale.SetActive (false);
			Particles.SetActive (false);
			KirbyFull.SetActive (true);
			Crunchdedede.SetActive (false);
			Idlededede2.SetActive (true);
			StartCoroutine (KirbySpit ());

		}
	}

	IEnumerator KirbySpit (){
		yield return new WaitForSeconds (1f);
		KirbyFull.SetActive (false);
		KirbyInhale2.SetActive (true);
		Star.SetActive (true);
	}

}
