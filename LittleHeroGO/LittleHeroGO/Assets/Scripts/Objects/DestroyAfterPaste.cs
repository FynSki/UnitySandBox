using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterPaste : MonoBehaviour {

// ========================================
//
// Destroy after collision Script
// version 1.0.0
// date - 2019-08-16
// created by Adam Janiszewski
//
// ========================================


// ========================================
//	VARIABLES
// ========================================
	public string tagName;


// ========================================
//	START
// ========================================

	void Start () {
		
	}
	
// ========================================
//	UPDATE
// ========================================
	void Update () {
		
	}

// ========================================
//	ON TRIGGER ENTER
// ========================================

	public void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag(tagName))
		{
			
			other.gameObject.SetActive (false);
		}
	}


}
