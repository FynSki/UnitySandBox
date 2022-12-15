using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class player_mov : MonoBehaviour {

// ======================================
// VARIABLES
// ======================================
	public float moveSpeed;

	// pref loader
	public string prefName;
	public int valueToGive;

	private Rigidbody2D rb2d;
	private Collider2D myCol;

	// Controller SetUp
	public int controllerNr;
	public GameObject controllerObject;

	// player stats
	public bool alive;

	// End Game
	public GameObject endGameInfo;



// ======================================
// START
// ======================================
	void Start () {
		// Get compontnts
		rb2d = GetComponent<Rigidbody2D>();	
		//myCol = GetComponent<Collider2D>();	

		alive = true;

		// PREF LOADER
		PrefLoader();
		

	}
	
// ======================================
// UPDATE
// ======================================
	void Update () 
	{
		
		// *********** Controller 
		if(valueToGive == 1)
		{
			controllerObject.SetActive(true);
			if(alive)
			{
				crosPlatformMove();
			}	
		}
		else
		{
			if(alive)
			{
				giroscopeControle();
			}
		}
	
		// *********** End Game
		if(alive == false)
		{
			PlayerLost();
		}
		
	}

// ======================================
// MOVE_1
// ======================================
	public void crosPlatformMove()
	{
		 if (CrossPlatformInputManager.GetAxisRaw("Horizontal") > 0.5f || CrossPlatformInputManager.GetAxisRaw("Horizontal") < -0.5f)
			{
				transform.Translate (new Vector3(CrossPlatformInputManager.GetAxisRaw("Horizontal")* moveSpeed * Time.deltaTime, 0f, 0f));
			}
		
		if(CrossPlatformInputManager.GetAxisRaw("Vertical") > 0.5f || CrossPlatformInputManager.GetAxisRaw("Vertical") < -0.5f)
			{
				transform.Translate ( new Vector3(0f, CrossPlatformInputManager.GetAxisRaw("Vertical")* moveSpeed * Time.deltaTime, 0f));
			}
	}
// ======================================
// MOVE_2
// ======================================
	public void giroscopeControle()
	{
		transform.Translate(Input.acceleration.x, Input.acceleration.y, 0);
	}

// ======================================
// END GAME
// ======================================

	public void PlayerLost()
	{
		rb2d.gravityScale = 5;
		endGameInfo.SetActive(true);
		alive = false;
		
	}
	// END FUNCTION

// =======================================
// PREF LOADER
// =======================================

	public void PrefLoader()
	{
		// wood count
		if(PlayerPrefs.HasKey(prefName))
					{
						valueToGive = PlayerPrefs.GetInt(prefName);
					}
	}
	// END FUNCTION

// =================================================================
// END SCRIPT
}
