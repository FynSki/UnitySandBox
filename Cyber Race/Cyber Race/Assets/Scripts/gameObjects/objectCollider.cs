using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectCollider : MonoBehaviour {

// ==========================================
// VARIABLE
// ==========================================
	public PointManager pointMgr;
	public int pointToGive;
	public string compareTagName;
// ==========================================
// START
// ==========================================
	void Start () {
		// Find Point Manager
		pointMgr = FindObjectOfType<PointManager>();
	}
	
// ==========================================
// UPDATE
// ==========================================
	void Update () {
		
	}

// ==========================================
// ON TRIGGER ENTR
// ==========================================
	void OnTriggerEnter2D(Collider2D other) {
		
		if (other.gameObject.CompareTag(compareTagName))
		{
			this.gameObject.SetActive (false);
			pointMgr.GivePoint(pointToGive);
		}

	}
// ==========================================
// END SCRIPT
}
