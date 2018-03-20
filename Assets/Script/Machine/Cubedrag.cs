using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cubedrag : MonoBehaviour {

	public Rigidbody rb;
	public Rigidbody hook;
	public float MaxDragDistance=5f;

	public float releaseTime=0.15f;
	private bool isPressed=false;

	void Start()
	{
	}

	void Update()
	{
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		if (isPressed) {
			if (Vector3.Distance (mousePos, hook.position) > MaxDragDistance) {
				rb.position = hook.position+( mousePos-hook.position).normalized*MaxDragDistance;
			}
			else
				rb.position =mousePos;

		}


	}

	void OnCollisionEnter(Collision other)
	{
	}

	IEnumerator WaitNextLevel()
	{
		yield return new WaitForSeconds (4f);
	}
		

	void OnMouseDown()
	{
		isPressed = true;

	}

	void OnMouseUp()
	{
		isPressed = false;
		StartCoroutine (Release ());
	}



	IEnumerator Release ()
	{
		yield return new WaitForSeconds (releaseTime);

		this.enabled = false;

		yield return new WaitForSeconds (0.2f);


	}


}
