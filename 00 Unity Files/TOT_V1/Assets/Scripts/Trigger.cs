using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
    public GameObject _targetUI;
    
    private void OnTriggerEnter(Collider other) {
        // set our ui text active here
        _targetUI.SetActive(true);
    }

}