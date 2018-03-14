using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public Transform target2;
	public Transform target3;
	public Transform target4;
	public GameObject Leva;
	public Movements ChangeCamera;
	public GameObject Leva1;
	public Triggers2 ChangeCamera2;

	public bool changethecamera=false;
	public bool changethecamera1=false;


	public float smoothSpeed=0.125f;
	public Vector3 offset;

	void Update(){
		ChangeCamera = Leva.GetComponent<Movements> ();
		changethecamera = ChangeCamera.changecamera;
		ChangeCamera2 = Leva1.GetComponent<Triggers2> ();
		changethecamera1 = ChangeCamera2.changecamera1;
	}

	void LateUpdate ()
	{
		if (changethecamera==false) {
			Vector3 desiredPosition = target.position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		} 
		if (changethecamera == true&&changethecamera1==false) {
			Vector3 desiredPosition = target2.position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;

		}
		if (changethecamera1 == true) {
			Vector3 desiredPosition = target3.position + offset;
			Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}
	}

}
