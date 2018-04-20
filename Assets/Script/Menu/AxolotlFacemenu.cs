using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxolotlFacemenu : MonoBehaviour {
	public GameObject eyes;
	public GameObject Facetwo;
	public GameObject FaceOne;
	public GameObject Facethree;
	public GameObject FaceFour;
	public GameObject Eyes2;
	public GameObject Eyes3;
	public GameObject Mouth;
	public GameObject Gills1;
	public GameObject Gills2;
	public GameObject Body;
	public GameObject Tail;
	public GameObject Arms;
	public ActualDialogue dialogue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (FaceOne!=null && Facetwo!=null   && Facethree!=null && FaceOne.transform.position.y < 2.5f ) {
			Destroy(FaceOne);
			eyes.SetActive (false);
			Facetwo.SetActive (true);

		}
		if (Facethree!=null && Facetwo!=null && Facetwo.transform.position.y <-8  ) {
			Facethree.SetActive (true);
			Destroy(Facetwo);
			StartCoroutine (axolotl ());
		
		}
	
	}

	IEnumerator axolotl(){
		yield return new WaitForSeconds (0.7f);
		Destroy(Facethree);
		FaceFour.SetActive (true);
		Eyes2.SetActive (true);
		Eyes3.SetActive (true);
		yield return new WaitForSeconds (0.3f);
		Mouth.SetActive (true);	
		yield return new WaitForSeconds (0.3f);
		Gills1.SetActive (true);
		yield return new WaitForSeconds (0.1f);
		Gills2.SetActive (true);
		yield return new WaitForSeconds (0.3f);
		Body.SetActive (true);
		yield return new WaitForSeconds (0.3f);
		Tail.SetActive (true);
		yield return new WaitForSeconds (0.3f);
		Arms.SetActive (true);
		yield return new WaitForSeconds (0.1f);
		FindObjectOfType<Dialogue> ().StartDialogue (dialogue);
	}
}
