using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
// ========================================
//
// Player Script
// version 1.0.3
// date - 2019-07-12
// update - 2019-08-20
// created by Adam Janiszewski
//
// ========================================

// ========================================
//	VARIABLES
// ========================================
	
	private Rigidbody2D myRigid;
	// player stats
	public float moveSpeed;
	public float jumpForce;

	public float currentMana;
	public float manaCosts;
	
	public float playerHp;
	public float playerPhisDmg;
	public float playerMagicDmg;
	public float playerRangeDmg;

	public int playerExp;
	public int playerLvl;
	// fire ball
	public GameObject fireObject;

	// layers
	private Collider2D myCol;
	public LayerMask whatIsBord;
	public bool onBoard;

	// point manager
	private pointAndStatManager pointMgr;

// ========================================
//	START
// ========================================
	void Start () {
		
		// myRigidBody
		myRigid = GetComponent<Rigidbody2D>();
		myCol = GetComponent<Collider2D>();

		pointMgr = FindObjectOfType<pointAndStatManager>();

		onBoard = true;
	}

// ========================================
//	UPDATE
// ========================================
	void Update () {
		
		
		// On Board
		onBoard = Physics2D.IsTouchingLayers(myCol, whatIsBord);
		// Stats update
		UpdateStats();

		// movement
		myRigid.velocity = new Vector2((moveSpeed), myRigid.velocity.y);

		// Current Mana
		currentMana = pointMgr.manaPoint;

	}

// ========================================
//	FUNCTIONS
// ========================================
	public void FireBall()
	{
		if(currentMana > manaCosts)
		{
			Instantiate(fireObject, transform.position, transform.rotation);
			pointMgr.MissManaFunc(manaCosts);
		}
		
	}

	public void JumpButton()
	{
		if(onBoard)
		{
			myRigid.velocity = new Vector2(myRigid.velocity.x, jumpForce);
		}
		
	}

	public void UpdateStats()
	{
		moveSpeed = pointMgr.moveSpeed;
		jumpForce = pointMgr.jumpForce;
	}
	


// END SCRIPT
}
