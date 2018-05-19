using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueStarter : MonoBehaviour {
	public ActualDialogue dialogue;
	public GameObject Text;
	public GameObject Balls;
	public GameObject Marowakhealth;
	public GameObject Maincharacterstopper;
	public GameObject PikachuLife;
	public GameObject Pikachu;
	public GameObject Pokeballs2;
	public GameObject Options;
	public GameObject ChooseArrow;
	public GameObject ArrowStopper;
	public GameObject Pokeballs3;
	public GameObject Backoptions;
	public GameObject Shoot;
	public GameObject Fainted;
	public GameObject MarowakStopper;
	public GameObject Poke;
	public GameObject marowakstopper2;
	public AudioClip ShootSound;
	private AudioSource source;


	// Use this for initialization
	void Start () {

			
		source=GetComponent<AudioSource> ();


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay2D (Collision2D coll)
	{

		if (coll.gameObject.tag == "Platform") {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.left * 10);
		}	

	}
	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "Wall1") {
			Text.SetActive (true);
			FindObjectOfType<Dialogue> ().StartDialogue (dialogue);
			StartCoroutine (DialogueDisappear ());
		}	
	}

	IEnumerator DialogueDisappear(){
		yield return new WaitForSeconds (1f);
		Text.SetActive (false);
		Balls.SetActive (false);
		Marowakhealth.SetActive (true);
		yield return new WaitForSeconds (1f);
		Maincharacterstopper.SetActive (false);
		Text.SetActive (true);
		FindObjectOfType<Dialogue> ().DisplayNextSentence ();
		yield return new WaitForSeconds (0.8f);
		PikachuLife.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		Pikachu.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		Text.SetActive (false);
		Pokeballs2.SetActive (true);
		Options.SetActive (true);
		ChooseArrow.SetActive (true);
		yield return new WaitForSeconds (1f);
		ArrowStopper.SetActive (false);
		yield return new WaitForSeconds (1f);
		Options.SetActive (false);
		ChooseArrow.SetActive (false);
		Pokeballs2.SetActive (false);
		Pokeballs3.SetActive (true);
		Backoptions.SetActive (true);
		yield return new WaitForSeconds (1f);
		Pokeballs3.SetActive (false);
		Backoptions.SetActive (false);
		Text.SetActive (true);
		FindObjectOfType<Dialogue> ().DisplayNextSentence ();
		yield return new WaitForSeconds (0.5f);
		source.PlayOneShot (ShootSound);
		Shoot.SetActive (true);
		yield return new WaitForSeconds (0.1f);
		Shoot.SetActive (false);
		Fainted.SetActive (true);
		Marowakhealth.SetActive (false);
		MarowakStopper.SetActive (false);
		yield return new WaitForSeconds (0.1f);
		marowakstopper2.SetActive (false);
		Poke.SetActive (true);
		FindObjectOfType<Dialogue> ().DisplayNextSentence ();
		yield return new WaitForSeconds (1f);
		SceneManager.LoadScene ("BubbleBobble");
	}
}
