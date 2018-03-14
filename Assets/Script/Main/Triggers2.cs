using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers2 : MonoBehaviour {
	public GameObject ball;
	public bool changecamera1=false;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D (Collider2D ball)
	{
		changecamera1 = true;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
