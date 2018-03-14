using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour {

	public GameObject menu;
	public GameObject opzioni;
	public Dropdown resolutionDropdown;
	public Animator Buttonpressed;

	Resolution[] resolutions;

	void Start()
	{
		resolutions = Screen.resolutions;

		resolutionDropdown.ClearOptions ();
		List<string>options=new List<string>();
		int currentResolutionIndex = 0;
		for (int i = 0; i < resolutions.Length; i++) 
		{
			string option = resolutions [i].width + "x" + resolutions [i].height;
			options.Add (option);
			if(resolutions[i].width ==Screen.currentResolution.width && resolutions[i].height==Screen.currentResolution.height)
			{
				currentResolutionIndex = i;
			}
		}		
		resolutionDropdown.AddOptions (options);
		resolutionDropdown.value = currentResolutionIndex;
		resolutionDropdown.RefreshShownValue ();
	}

	public void PlayButton()
	{
		StartCoroutine (WaitAnimation ());
		Buttonpressed.SetBool ("ButtonPressed", true);


	}

	public void Options()
	{
		menu.SetActive (false);
		opzioni.SetActive (true);
	}

	public void Exit()
	{
		Application.Quit ();
	}

	IEnumerator WaitAnimation ()
	{
		yield return new WaitForSeconds (2f);
		SceneManager.LoadScene(1);
	}

	public void returntoMenu()
	{
		menu.SetActive (true);
		opzioni.SetActive (false);
	}

	public void Setresolution(int resolutionIndex)
	{
		Resolution resolution = resolutions [resolutionIndex];
		Screen.SetResolution (resolution.width, resolution.height, Screen.fullScreen);
	}
}
