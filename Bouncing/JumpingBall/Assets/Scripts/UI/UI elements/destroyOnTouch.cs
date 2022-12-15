using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnTouch : MonoBehaviour {

// ==================================
// ============ ON TRIGGER ==========
// ==================================
	void Start () {
		
	}
	
// ==================================
// ============ ON TRIGGER ==========
// ==================================
	void Update () {
		
	}

// ==================================
// ============ ON TRIGGER ==========
// ==================================
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("PointUI"))
				{
					other.gameObject.SetActive (false);
				}
	}



}
