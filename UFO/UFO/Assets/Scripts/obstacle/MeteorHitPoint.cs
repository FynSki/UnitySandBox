using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorHitPoint : MonoBehaviour {

// ==========================================
// VARIABLES
// ==========================================
	public string tagName;
	public int liveCount;

	public GameObject objectToSpawn;
// ==========================================
// START
// ==========================================
	void Start () {
		
	}
	
// ==========================================
// UPDATE
// ==========================================
	void Update () {
		
		if(liveCount < 1)
		{
			Instantiate(objectToSpawn, transform.position, transform.rotation);
			this.gameObject.SetActive(false);
		}
	}

// ==========================================
// ON TRIGGER ENTER 2D
// ==========================================
	 void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.CompareTag(tagName))
        {
			liveCount = liveCount - 1;
			other.gameObject.SetActive(false);
		}
	}

// END SCRIPT

}
