using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollider : MonoBehaviour {

	public GameObject Player;
	public GameObject Presents;

	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter2D (Collider2D Player)
	{
		Presents.SetActive (false);
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
