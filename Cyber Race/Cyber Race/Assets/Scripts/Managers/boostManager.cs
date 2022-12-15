using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boostManager : MonoBehaviour {

// ============================================
// VARIABLES
// ============================================
	
	// Point Manager
	private PointManager pointMgr;

	public int powerUpPoint;

// ============================================
// VARIABLES
// ============================================
	void Start () {
		// Find PointManagr object
		pointMgr = FindObjectOfType<PointManager>();
	}
	
// ============================================
// VARIABLES
// ============================================
	void Update () {
		powerUpPoint = pointMgr.powerUpPoint;
	}

// ============================================
// VARIABLES
// ============================================


// END SCRIPT
}
