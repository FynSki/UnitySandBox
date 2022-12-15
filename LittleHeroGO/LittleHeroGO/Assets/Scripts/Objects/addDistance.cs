using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addDistance : MonoBehaviour {
// ========================================
//
// add distance Script
// version 1.0.0
// date - 2019-08-16
// created by Adam Janiszewski
//
// ========================================


// ========================================
//	VARIABLES
// ========================================
	public string tagName;

	private pointAndStatManager pointMgr;
	public int distanceToAdd;
	public int extTpAdd;
// ========================================
//	START
// ========================================
	void Start () {
		pointMgr = FindObjectOfType<pointAndStatManager>();
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
		pointMgr.addDistance(distanceToAdd);
		pointMgr.addExp(extTpAdd);
		this.gameObject.SetActive(false);
	}

// End Script
}
