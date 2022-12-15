using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointClicked : MonoBehaviour {
// ========================================
// 			POINT CLICKED BY PLAYER
// 				point behavior
// 
// ========================================

// ========================================
//				VARIABLES
// ========================================


	private pointManager pointMgr;
	public float pointsToAdd;
	public float timeToAdd;
	

	// curage
	public int curageToRemove;
	public int curageMultiplier;
	public int curageToAdd;


	// time point
	public float currentTime;
	public float targetTime;
	public float pointPerSec;
	public float multiplierPoint;

	// INSTANTIATE
	public GameObject plusPoint;
	public GameObject minusPoint;

// ========================================
//				START
// ========================================
	void Start () {
		pointMgr = FindObjectOfType<pointManager>();

		pointMgr.ScarreBar(curageToRemove);
	}
	
// ========================================
//				UPDATE
// ========================================
	void Update () {
		currentTime -= pointPerSec * Time.deltaTime;

		RemPoint();
		
	}

// ========================================
//				FUNKCJE
// ========================================

	void OnMouseDown()
		{
			pointsToAdd = currentTime * multiplierPoint;
			this.gameObject.SetActive(false);
			pointMgr.AddPoints(pointsToAdd , timeToAdd);
			pointMgr.AddCurage(curageToAdd);
			Instantiate(plusPoint, transform.position, transform.rotation);
		}
	
	void RemPoint()
	{

		
		if(currentTime < targetTime)
		{
			pointMgr.ScarreBar(curageToRemove * curageMultiplier);
			Instantiate(minusPoint, transform.position, transform.rotation);
			this.gameObject.SetActive(false);
		}
	}

// end script
}
