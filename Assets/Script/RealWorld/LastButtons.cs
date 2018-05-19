using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Restart()
	{
		SceneManager.LoadScene (2);
	}

	public void BackToMenu()
	{
		SceneManager.LoadScene (1);
	}

	public void Credits()
	{
		SceneManager.LoadScene (13);
	}

}
