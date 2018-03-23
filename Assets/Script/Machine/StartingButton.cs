using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingButton : MonoBehaviour {

	public GameObject Canvas;

	// Use this for initialization
	void Start () {
		Time.timeScale = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Gopressed()
	{
		Time.timeScale = 1.0f;
		Canvas.SetActive (false);


	}
}
