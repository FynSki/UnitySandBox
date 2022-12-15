using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoint : MonoBehaviour {

// ======================================
// VARIABLES
// ======================================
	// point to give
	public int pointToGive;
	public string pointMgrTag;
	// point manager
	private PointManager pointMgr;

// ======================================
// START
// ======================================
	void Start () {
		pointMgr = FindObjectOfType<PointManager>();
	}

// ======================================
// UPDATE
// ======================================
	void Update () {
		
	}
// ======================================
// ON TRIGGER ENTER
// ======================================
	void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.CompareTag(pointMgrTag))
        {
			pointMgr.GivePoint(pointToGive);
			this.gameObject.SetActive(false);
		}
		
	}

// END SCRIPT
}
