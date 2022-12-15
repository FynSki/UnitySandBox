using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivByPlayer : MonoBehaviour {

// ======================================
// ============== ZMIENNE ===============
// ======================================
	public string tagName;

	public GameObject obstacleToActive;
	public GameObject obstacleToDeactive;
	
// ======================================


// ======================================
// ========== ON TRIGGER ACTIVE =========
// ======================================
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag(tagName))
				{
					obstacleToActive.SetActive(true);
					obstacleToDeactive.SetActive(false);
					
				}
	}
// ======================================

// END SCRIPT

}
