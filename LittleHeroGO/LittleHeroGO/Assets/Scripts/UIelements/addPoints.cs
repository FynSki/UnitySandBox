using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addPoints : MonoBehaviour {
// ========================================
//
// ADDpOINTS Script
// version 1.0.1
// date - 2019-07-19
// update - 2019-07-24
// created by Adam Janiszewski
//
// ========================================
	
// ========================================
//	VARIABLES
// ========================================
	private pointAndStatManager pointMgr;

	public float hpToAdd;
	public float speedToAdd;
	public float jumpToAdd;
	
// ========================================
//	START
// ========================================
	void Start () {
		pointMgr = FindObjectOfType<pointAndStatManager>();
	}
	
// ========================================
//	FUNCTION
// ========================================
	public void AddStatPoints()
	{
		pointMgr.addHP(hpToAdd);
		pointMgr.addSpeed(speedToAdd);
		pointMgr.addForce(jumpToAdd);
		
	}

// END SCRIPT
}
