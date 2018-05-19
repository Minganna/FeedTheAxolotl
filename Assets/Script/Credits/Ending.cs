using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour {

	public ActualDialogue dialogue;
	public GameObject Pimball;
	public GameObject Breakout;
	public GameObject DonkeyKong;
	public GameObject Tetris;
	public GameObject PunchOut;
	public GameObject DuckHunt;
	public GameObject Pokemon;
	public GameObject BubbleBobble;
	public GameObject Kirby;
	public GameObject Zelda;
	public GameObject Logo;
	public GameObject Darumarke;
	public GameObject Darumark2;
	public Animator Darumark;
	public GameObject BU;
	public GameObject[] Texts;
	public GameObject Mushu;

	// Use this for initialization
	void Start () {
		StartCoroutine (Credits ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Credits()
	{
		yield return new WaitForSeconds (1f);
		FindObjectOfType<Dialogue> ().StartDialogue (dialogue);
		Pimball.SetActive (true);
		yield return new WaitForSeconds (3f);
		Pimball.SetActive (false);
		yield return new WaitForSeconds (0.1f);
		FindObjectOfType<Dialogue> ().DisplayNextSentence ();
		Breakout.SetActive (true);
		yield return new WaitForSeconds (3f);
		Breakout.SetActive (false);
		yield return new WaitForSeconds (0.1f);
		FindObjectOfType<Dialogue> ().DisplayNextSentence ();
		DonkeyKong.SetActive (true);
		yield return new WaitForSeconds (3f);
		DonkeyKong.SetActive (false);
		yield return new WaitForSeconds (0.1f);
		FindObjectOfType<Dialogue> ().DisplayNextSentence ();
		Tetris.SetActive (true);
		yield return new WaitForSeconds (3f);
		Tetris.SetActive (false);
		yield return new WaitForSeconds (0.1f);
		FindObjectOfType<Dialogue> ().DisplayNextSentence ();
		PunchOut.SetActive (true);
		yield return new WaitForSeconds (3f);
		PunchOut.SetActive (false);
		yield return new WaitForSeconds (0.1f);
		FindObjectOfType<Dialogue> ().DisplayNextSentence ();
		DuckHunt.SetActive (true);
		yield return new WaitForSeconds (3f);
		DuckHunt.SetActive (false);
		yield return new WaitForSeconds (0.1f);
		FindObjectOfType<Dialogue> ().DisplayNextSentence ();
		Pokemon.SetActive (true);
		yield return new WaitForSeconds (3f);
		Pokemon.SetActive (false);
		yield return new WaitForSeconds (0.1f);
		FindObjectOfType<Dialogue> ().DisplayNextSentence ();
		BubbleBobble.SetActive (true);
		yield return new WaitForSeconds (3f);
		BubbleBobble.SetActive (false);
		yield return new WaitForSeconds (0.1f);
		FindObjectOfType<Dialogue> ().DisplayNextSentence ();
		Kirby.SetActive (true);
		yield return new WaitForSeconds (3f);
		Kirby.SetActive (false);
		yield return new WaitForSeconds (0.1f);
		FindObjectOfType<Dialogue> ().DisplayNextSentence ();
		Zelda.SetActive (true);
		yield return new WaitForSeconds (3f);
		Zelda.SetActive (false);
		yield return new WaitForSeconds (0.1f);
		FindObjectOfType<Dialogue> ().DisplayNextSentence ();
		Logo.SetActive (true);

		yield return new WaitForSeconds (3f);
		FindObjectOfType<Dialogue> ().DisplayNextSentence ();
		Logo.SetActive (false);
		yield return new WaitForSeconds (0.1f);

		Darumark.SetBool ("MovingtoCenter", true);
		BU.SetActive (true);
		yield return new WaitForSeconds (3.5f);

		Darumarke.SetActive (false);
		Darumark2.SetActive (true);
		yield return new WaitForSeconds (1f);
		Texts [0].SetActive (false);
		Texts [1].SetActive (true);
		Mushu.SetActive (true);
		yield return new WaitForSeconds (2f);
		Application.Quit ();


	}
}
