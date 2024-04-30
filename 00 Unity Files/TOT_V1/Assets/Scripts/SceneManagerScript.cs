using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
	
	// This will load a scene based on the name
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
