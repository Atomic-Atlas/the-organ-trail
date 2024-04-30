using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {
	
	public Text dialogueText;

	// Put sentences into queue that are then
	// loaded up to the user.
	private Queue<string> sentences;
	
	void Start () {
		// Initiate a new instance of a queue
		sentences = new Queue<string>();
	}
	
	public void StartDialogue (Dialogue dialogue) {
		//Debug.Log("Starting conversation with " + dialogue.name);

		// Clear any previous sentences
		sentences.Clear();
		
		// For each of the sentences in the script,
		foreach (string sentence in dialogue.sentences) {
			sentences.Enqueue(sentence);
		}
		
		// Go to the next sentence
		DisplayNextSentence();
	
	}
	
	public void DisplayNextSentence () {
		
		// Check if there are anymore sentences in queue
		if (sentences.Count == 0) {
			
			// Exit the dialogue system
			EndDialogue();
			return;
		}
		
		// If there are sentences left
		string sentence = sentences.Dequeue(); // Store in a string variable named "sentence"
		dialogueText.text = sentence;
		//Debug.Log(sentence);
	}
	
	void EndDialogue() {
		Debug.Log("End of the script.");
	}
	
}
