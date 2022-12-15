using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour {

// ============================================
// VARIABLES
// ============================================


	// TAG string for objects
	public string pointTagString;
	public string EndGameTag;
	public string timePointTag;
	public string boostPointTag;

	public float timeToGive;
	public int powerToGive;

	// Find Player OBJ
	private player_mov PlayerMovement;
	private PointManager pointMgr;

	// instantiate
	public GameObject objectToSpawnPoint;


// ============================================
// START
// ============================================
	void Start () {
		
		// find Player obj at start
		PlayerMovement = FindObjectOfType<player_mov>();
		pointMgr = FindObjectOfType<PointManager>();
	}
	
// ============================================
// UPDATE
// ============================================
	void Update () {
		
	}
// ============================================
// ON TRIGGER ENTER
// ============================================
	void OnTriggerEnter2D(Collider2D other)
    {
		// if point
		if (other.gameObject.CompareTag(pointTagString))
        {
			Instantiate(objectToSpawnPoint, transform.position, transform.rotation);
			other.gameObject.SetActive(false);
		}

		// if endGame
		if (other.gameObject.CompareTag(EndGameTag))
        {
			PlayerMovement.PlayerLost();
		}

		// if time point
		if (other.gameObject.CompareTag(timePointTag))
        {
			pointMgr.GiveTime(timeToGive);
			other.gameObject.SetActive(false);
		}

		// if time point
		if (other.gameObject.CompareTag(boostPointTag))
        {
			pointMgr.GivePowerUp(powerToGive);
			other.gameObject.SetActive(false);
		}

	
	}



// END SCRIPT
}
