using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleActiveScript : MonoBehaviour {

	// Create a reference to the object
	public GameObject obj; // Note: can't just name this
						   // "object" for some reason.
	
	// Create a boolean
	public bool activated;

    // Update is called once per frame
	void Update() {
		
		// If "activated" is checked, make SetActive true
		if (activated == true)
		{
			obj.SetActive(true);
		} else {
			
			// Otherwise, set it to false
			obj.SetActive(false);
		}
    	
	}
}
