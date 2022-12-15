using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour {

// ========================================
//
// Box Script
// version 1.0.0
// date - 2019-09-04
// update - 
// created by Adam Janiszewski
//
// ========================================

// ========================================
//	VARIABLES
// ========================================

	public Sprite boxIsOpen;
	public GameObject[] lootToSpawn;


// ========================================
//	START
// ========================================
	void Start () {
		
	}
	
// ========================================
//	FUNCTIONS
// ========================================

	void OnTriggerEnter2D(Collider2D other)
	{
		// Player Fire Ball
		if(other.gameObject.CompareTag("fireBall"))
		{
			Instantiate(lootToSpawn[Random.Range(0,lootToSpawn.Length)], transform.position, transform.rotation);
			this.gameObject.SetActive(false);
			
		}


	}

// END SCRIPT
}
