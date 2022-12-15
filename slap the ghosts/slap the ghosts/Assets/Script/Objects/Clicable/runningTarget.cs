using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runningTarget : MonoBehaviour {

// ==================================
// VARIABLES
// ==================================
	
	private Rigidbody2D myRigidbody;
	private Vector3 moveDirection;
	
	public float moveSpeed;
	public float minSpeed;
	public float maxSpeed;
	// directions
	public float minXDir;
	public float maxXDir;
	public float minYDir;
	public float maxYDir;
	// bools
	private bool moving;
	// time
	public float timeBetweenMove; // how long it is staing
	private float timeBetweenMoveCounter;
	public float timeToMove; // how long it is moving
	private float timeToMoveCounter;


// ==================================
// START
// ==================================
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
		
		//timeBetweenMoveCounter = timeBetweenMove; // maybe it will be used later
		//timeToMoveCounter = timeToMove;			// maybe it will be used later

		timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f , timeBetweenMove * 0.25f );
		timeToMoveCounter = Random.Range(timeToMove * 0.75f , timeToMove * 0.25f );

		
	}
	
// ==================================
// UPDATE
// ==================================
	void Update () {
		
		// moving
		if(moving)
		{
			timeToMoveCounter -= Time.deltaTime;
			myRigidbody.velocity = moveDirection;

			if(timeToMoveCounter < 0f)
			{
				moving = false;
				//timeBetweenMoveCounter = timeBetweenMove;
				timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.01f , timeBetweenMove * 0.25f );
				moveSpeed = Random.Range(minSpeed , maxSpeed);
			}

		}
		else
		{
			timeBetweenMoveCounter -= Time.deltaTime;
			// IF
			if(timeBetweenMoveCounter < 0f)
			{
				moving = true;
				//timeToMoveCounter = timeToMove;
				timeToMoveCounter = Random.Range(timeToMove * 0.75f , timeToMove * 0.25f );
				// new direction
				moveDirection = new Vector3 ( Random.Range(minXDir , maxXDir) * moveSpeed , Random.Range(minYDir , maxYDir) * moveSpeed , 0f );
			}
		}


	// END UPDATE	
	}

// END SCRIPT
}
