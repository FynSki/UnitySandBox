using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour {

// ==========================================
// VARIABLES
// ==========================================


// ==========================================
// START
// ==========================================
	void Start () {
		
	}
	
// ==========================================
// UPDATE
// ==========================================
	void Update () {
		
	}
// ==========================================
// ON TRIGGER ENTER
// ==========================================
	void OnTriggerEnter2D(Collider2D other)
    {
		other.gameObject.SetActive (false);
	}

// END SCRIPT
}
