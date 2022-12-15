using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera : MonoBehaviour {


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
