using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basketcollide : MonoBehaviour {
	public GameObject Basket1;
	private Basket StartBasket;
	private bool UP;
	public GameObject object4;



	// Use this for initialization
	void Start () {
		
		StartBasket = Basket1.GetComponent<Basket> ();
		UP = StartBasket.StartUp;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "EditorOnly") {
			UP = true;
			StartBasket.GetComponent<Basket> ().StartUp=true;
			object4.SetActive (false);


		}

	}
}
