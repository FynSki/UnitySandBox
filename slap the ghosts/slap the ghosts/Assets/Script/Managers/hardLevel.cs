using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hardLevel : MonoBehaviour {

// ========================================
// 			POZIOM TRUDNOSCI POINTMANAGER
// 				adding additional spwans
// 
// ========================================

// ========================================
//				VARIABLES
// ========================================
	//private pointManager pointMgr;
	public float currentTime;
	public int pointPerSec;
	public float timeTarget;
	public GameObject toInstant;
// ========================================
//				START
// ========================================
	void Start () {
		//pointMgr = FindObjectOfType<pointManager>();
	}
	
// ========================================
//				UPDATE
// ========================================
	void Update () {
		currentTime += pointPerSec * Time.deltaTime;

		//restart Time
		if(currentTime > timeTarget)
		{
			Instantiate(toInstant, transform.position, transform.rotation);
			currentTime = 0f;
		}
	}
}
