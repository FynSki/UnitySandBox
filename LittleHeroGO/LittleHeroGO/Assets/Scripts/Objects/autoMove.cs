using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoMove : MonoBehaviour {
// ========================================
//
// autoMove Script
// version 1.0.0
// date - 2019-07-19
// created by Adam Janiszewski
//
// ========================================

// ========================================
//	VARIABLES
// ========================================

	private Rigidbody2D myRigidbody;
	public float moveSpeed;
	public float xDir;
	public float yDir;
	public float zDir;

// ========================================
//	START
// ========================================
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
	}
	
// ========================================
//	UPDATE
// ========================================
	void Update () {
		myRigidbody.velocity = new Vector3(xDir * moveSpeed, yDir * moveSpeed, zDir * moveSpeed);
	}
}
