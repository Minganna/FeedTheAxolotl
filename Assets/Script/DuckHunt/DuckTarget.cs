using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckTarget : MonoBehaviour {

	public Transform[] targets=new Transform[1];






	public float smoothSpeed=0.125f;
	public Vector3 offset;

	void Start(){

	}

	void Update(){

	}

	void LateUpdate ()
	{
			Vector3 desiredPosition = targets [0].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		} 
	}



