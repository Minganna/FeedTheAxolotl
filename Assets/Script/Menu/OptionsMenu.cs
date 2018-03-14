using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour {

	public AudioMixer Mainmixer;

	public void SetVolume (float volume)
	{
		Mainmixer.SetFloat ("MainVolume",volume);
	}

	public void SetQuality(int qualityIndex)
	{
		QualitySettings.SetQualityLevel (qualityIndex);
	}

	public void SetFullScreen(bool fullscreen)
	{
		Screen.fullScreen = fullscreen;
	}
}

