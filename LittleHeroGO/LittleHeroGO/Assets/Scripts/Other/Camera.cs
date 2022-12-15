using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera : MonoBehaviour {
// ========================================
//
// Camera Follow Script
// version 1.0.0
// date - 2019-07-18
// created by Adam Janiszewski
//
// ========================================

// ************************************************************
// *********************** ZMIENNE ****************************
// ************************************************************
	public GameObject thePlayer;
	private Vector3 lastPlayerPosition;
	private float distanceToMove;
	
// ************************************************************


// ***********************************************************
// *********************** START *****************************
// ***********************************************************
	void Start () 
	{
		//thePlayer = GameObject.Find ("Player");
		
		//thePlayer = FindObjectOfType<Player_movement>();
		lastPlayerPosition = thePlayer.transform.position;
	}
// ***********************************************************


	
// ******************************************************************
// ************************* UPDATE *********************************
// ******************************************************************
	void Update () 
	{
		//******************* FIND PLAYER OBJECT *****************
		//********************************************************
		thePlayer = GameObject.FindWithTag ("Player");
		// *******************************************************
		
		
		distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x;
		transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);


		lastPlayerPosition = thePlayer.transform.position;
	}
// ***********************************************************
}
