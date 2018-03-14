using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUP : MonoBehaviour {

	public GameObject Leva1;
	public Triggers2 ChangeCamera2;
	public bool changethecamera1=false;
	public float playerJumpPower=1000;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ChangeCamera2 = Leva1.GetComponent<Triggers2> ();
		changethecamera1 = ChangeCamera2.changecamera1;
		if (changethecamera1 == true) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * playerJumpPower);
		}
	}


}
