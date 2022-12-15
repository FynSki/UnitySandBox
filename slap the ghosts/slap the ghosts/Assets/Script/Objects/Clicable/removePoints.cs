using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removePoints : MonoBehaviour {

// ========================================
// 			POINT CLICKED BY PLAYER
// 				point behavior
// 
// ========================================

// ========================================
//				VARIABLES
// ========================================
	private pointManager pointMgr;
	public int curageToRemove;
	public int curageMultiplier;
	public GameObject objectToInstantiate;

// ========================================
//				VARIABLES
// ========================================
	void Start () {
		pointMgr = FindObjectOfType<pointManager>();

		pointMgr.ScarreBar(curageToRemove);
	}
	
// ========================================
//				VARIABLES
// ========================================
	void Update () {
		
	}

// ========================================
//				VARIABLES
// ========================================
	void OnMouseDown()
		{
			pointMgr.ScarreBar(curageToRemove * curageMultiplier);
			this.gameObject.SetActive(false);
			Instantiate(objectToInstantiate, transform.position, transform.rotation);	
		}

// END SCRIPT
}
