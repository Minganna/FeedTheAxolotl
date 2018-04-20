using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleBobblefollowing : MonoBehaviour {

	public Transform[] targets=new Transform[4];
	public GameObject Object1;
	public GameObject Object2;
	public GameObject Object3;
	public GameObject Object4;







	public float smoothSpeed=0.125f;
	public Vector3 offset;

	void Start(){

	}

	void Update(){

	}

	void LateUpdate ()
	{
		if (Object1!=null) {
			Vector3 desiredPosition = targets [0].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		} else if(Object2!=null) {
			Vector3 desiredPosition = targets [1].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}
		else if(Object3!=null) {
			Vector3 desiredPosition = targets [2].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}
		else if(Object4!=null) {
			Vector3 desiredPosition = targets [4].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}
	}
}

