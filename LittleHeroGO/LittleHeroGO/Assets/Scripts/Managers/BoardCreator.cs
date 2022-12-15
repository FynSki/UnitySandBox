using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardCreator : MonoBehaviour {
// ========================================
//
// Board Creator Manager Script
// version 1.0.0
// date - 2019-07-25
// update - 
// created by Adam Janiszewski
//
// ========================================


// ========================================
// ============= ZMIENNE ==================
// ========================================
	public GameObject[] thePlatform;
	public Transform generationPoint;
	public float distanceBetween;
	private float platformWidth;
// ========================================

	// Use this for initialization
	void Start () {
		//platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(transform.position.x < generationPoint.position.x)
		{
			transform.position = new Vector3(transform.position.x + distanceBetween + platformWidth, 0f, transform.position.z);
			Instantiate(thePlatform[Random.Range(0,thePlatform.Length)], transform.position, transform.rotation);
		
		}		
	}
}
