using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BordCreator : MonoBehaviour {
// ========================================================
// ===================== VARIABLES ========================
// ========================================================
	// List of Game Parts that can be used
	public GameObject[] thePlatform;
	// point out of the camera range that "trigger" creation of new map part
	public Transform generationPoint;
	public float distanceBetween;

// ========================================================
// ===================== START ============================
// ========================================================
	// Use this for initialization
	void Start () {
		
	}
	
// ========================================================
// ===================== UPDATE ===========================
// ======================================================== 
	void Update () {
		
		//
		// check position of the generation point and if it is graten than current possition 
		// it take random object from the list and instantiate it in the next possition
		//
		if(transform.position.y < generationPoint.position.y)
				{
					transform.position = new Vector3( 0f, transform.position.y + distanceBetween, 0f);
					Instantiate(thePlatform[Random.Range(0,thePlatform.Length)], transform.position, transform.rotation);
				
				}	

			}

// END GAME
}
