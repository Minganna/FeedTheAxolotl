using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollowmachine : MonoBehaviour {

	public Transform[] targets=new Transform[3];
	public GameObject Object1;






	public float smoothSpeed=0.125f;
	public Vector3 offset;

	void Start(){

	}

	void Update(){

	}

	void LateUpdate ()
	{
		if (Object1.activeSelf) {
			Vector3 desiredPosition = targets [0].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		} else {
			Vector3 desiredPosition = targets [1].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}
	}

}
	
