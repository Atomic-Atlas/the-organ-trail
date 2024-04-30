using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {
	
	public Dialogue dialogue;
	
	public void TriggerDialogue () {
		
		// Locate the dialogue
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}
	
}
