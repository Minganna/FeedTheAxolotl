using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour {

	public Text dialogueText;

	private int DialogueCount=0;


	private Queue<string> sentences;

	// Use this for initialization
	void Start () {

		sentences= new Queue<string>();

	}

	public void StartDialogue(ActualDialogue dialogue)
	{
		sentences.Clear ();


		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue (sentence);
		}


		DisplayNextSentence ();
	}

	public void DisplayNextSentence()
	{
		if (sentences.Count == 0) 
		{
			EndDialogue ();
			return;
		}
		string sentence = sentences.Dequeue ();
		StopAllCoroutines ();
		StartCoroutine (TypeSentence(sentence));

	}

	IEnumerator TypeSentence (string sentence)
	{

		dialogueText.text = "";
		foreach(char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
	}

	void EndDialogue()
	{

	
		if (DialogueCount == 1) {

		

		}
	

	}
}