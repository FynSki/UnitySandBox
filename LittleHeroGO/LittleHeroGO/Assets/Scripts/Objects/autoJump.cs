using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoJump : MonoBehaviour {

// ========================================
//
// autoJump Script
// version 1.0.1
// date - 2019-07-28
// created by Adam Janiszewski
//
// ========================================

// ========================================
//	VARIABLES
// ========================================
	public float jumpForce;
	private Rigidbody2D myRigid;
// ========================================
//	START
// ========================================
	void Start () {
		myRigid = GetComponent<Rigidbody2D>();

		StartCoroutine(AutoJump());
	}
	
// ========================================
//	UPDATE
// ========================================
	void Update () {
		
	}
// ========================================
//	UPDATE
// ========================================
	IEnumerator AutoJump()
	{
		myRigid.velocity = new Vector2(myRigid.velocity.x, jumpForce);
		yield return new WaitForSeconds(2);
		myRigid.velocity = new Vector2(myRigid.velocity.x, 0f);
	}

// END SCRIPT
}
