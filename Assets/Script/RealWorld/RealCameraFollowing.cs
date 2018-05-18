using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealCameraFollowing : MonoBehaviour {

	public Transform[] targets=new Transform[3];
	public GameObject Object1;
	public GameObject Object2;
	public GameObject Object3;
	public GameObject Object4;
	public GameObject Object5;
	public GameObject Object6;
	public GameObject Object7;





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
		}
		if (!Object1.activeSelf && Object2.activeSelf) {
			Vector3 desiredPosition = targets [1].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}
		if (!Object1.activeSelf && !Object2.activeSelf && Object3.activeSelf) {
			offset = new Vector3 (-10, 10, -20);
			Vector3 desiredPosition = targets [1].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}
		if (!Object3.activeSelf &&!Object1.activeSelf && !Object2.activeSelf && Object4.activeSelf ) {
			offset = new Vector3 (-10, 30, -70);
			Vector3 desiredPosition = targets [2].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}
		if (!Object4.activeSelf &&!Object3.activeSelf &&!Object1.activeSelf && !Object2.activeSelf && Object5.activeSelf) {
			offset = new Vector3 (100, 70, -70);
			Vector3 desiredPosition = targets [2].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}

		if (!Object5.activeSelf&&!Object4.activeSelf &&!Object3.activeSelf &&!Object1.activeSelf && !Object2.activeSelf && Object6.activeSelf) {
			offset = new Vector3 (0, 20, -70);
			Vector3 desiredPosition = targets [3].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}
		if (!Object6.activeSelf&&!Object5.activeSelf&&!Object4.activeSelf &&!Object3.activeSelf &&!Object1.activeSelf && !Object2.activeSelf && Object7.activeSelf ) {
			offset = new Vector3 (0, 0, -5);
			smoothSpeed = 1;
			Vector3 desiredPosition = targets [4].position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}
	}


}
