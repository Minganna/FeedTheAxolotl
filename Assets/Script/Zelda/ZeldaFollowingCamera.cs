using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeldaFollowingCamera : MonoBehaviour {


	public Transform[] targets=new Transform[4];
	public GameObject Object1;
	public GameObject Object2;
	public GameObject Object3;
	public GameObject Object4;
	public GameObject Arrow;
	public GameObject Star1;





	public float smoothSpeed=1f;
	public Vector3 offset;

	void Start(){
		StartCoroutine (changeCamera ());
	}

	void Update(){

	}

	void LateUpdate ()
	{
		if (Object1.activeSelf) {
			Vector3 desiredPosition = targets [0].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}
		if (Object2.activeSelf) {
			Vector3 desiredPosition = targets [1].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}
		if (Object3.activeSelf) {
			Vector3 desiredPosition = targets [2].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;

		}
		if (Object4.activeSelf) {
			Vector3 desiredPosition = targets [3].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}
	}

	IEnumerator changeCamera (){
		yield return new WaitForSeconds (1f);
		Object1.SetActive (false);
		Object2.SetActive (true);
		yield return new WaitForSeconds (1f);
		Object3.SetActive (true);
		Object2.SetActive (false);
	
		yield return new WaitForSeconds (1f);
		Arrow.SetActive (true);
		Star1.SetActive (false);
		Object3.SetActive (false);
		Object4.SetActive (true);

	}

}

