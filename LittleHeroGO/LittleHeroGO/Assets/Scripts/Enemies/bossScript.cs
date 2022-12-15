using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossScript : MonoBehaviour {

// ========================================
//
// boss Script
// version 1.0.0
// date - 2019-08-27
// update - 
// created by Adam Janiszewski
//
// ========================================

// ========================================
//	VARIABLES
// ========================================
	private pointAndStatManager pointMgr;
	
	// Boss stats
		public float bossBaseHp;
		public float bossHp;




	// boss base worth
		public int baseBossExp;
	

	// Boss worth
		public int extTpAdd;
// ========================================
//	START
// ========================================
	void Start () {
		pointMgr = FindObjectOfType<pointAndStatManager>();

		bossHp = bossBaseHp + (pointMgr.distancePoint * bossBaseHp);
		extTpAdd = baseBossExp + (baseBossExp * pointMgr.distancePoint);
	}
	
// ========================================
//	UPDATE
// ========================================
	void Update () {
		
	}

// ========================================
//	FUNCTIONS
// ========================================


// END SCRIPT
}
