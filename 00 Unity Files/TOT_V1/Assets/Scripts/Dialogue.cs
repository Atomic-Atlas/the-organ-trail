using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue {

	public string name;

	// Sentences that will load into queue
	[TextArea(3, 10)]				// Minimum amount of area
	public string[] sentences;		// text will use is 3, max is 10

}
