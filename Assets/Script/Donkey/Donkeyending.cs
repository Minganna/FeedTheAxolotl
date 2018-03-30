using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Donkeyending : MonoBehaviour {
	public Animator Barrel;
	public Animator Flame;
	public Animator Rope;

	// Use this for initialization
	void Start () {
		StartCoroutine(FlameAnimation());
		
	}


	
	// Update is called once per frame
	void Update () {
		
	}


	IEnumerator FlameAnimation()
	{
		yield return new WaitForSeconds (2.1f);
		Barrel.SetBool ("Isflame", false);
		Flame.SetBool ("Isover", true);
		Rope.SetBool ("burning", true);
		yield return new WaitForSeconds (0.5f);
		SceneManager.LoadScene ("Tetris");
	}
}
