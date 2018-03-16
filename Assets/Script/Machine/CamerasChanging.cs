using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasChanging : MonoBehaviour {
	public Camera[] cams;
	public int switchcameras=1;


		

	public void MainCam ()
	{
		if (switchcameras == 3) {
			cams [0].enabled = false;
			cams [1].enabled = true;
			cams [2].enabled = false;
			switchcameras = 0;
		}
		
		if (switchcameras == 2) {
			cams [0].enabled = false;
			cams [1].enabled = false;
			cams [2].enabled = true;

		}
		if (switchcameras == 1) {
			cams [0].enabled = true;
			cams [1].enabled = false;
			cams [2].enabled = false;

		}
		switchcameras = switchcameras + 1;

	}
}

