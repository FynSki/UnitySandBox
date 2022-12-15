using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setPref : MonoBehaviour {

// ===================================
// PREFABY
// ===================================

	public string prefName;
	public int valueToGive;


// ===================================
// PREFABY
// ===================================
	void Start () {
		
	}
	
// ===================================
// PREFABY
// ===================================
	void Update () {
		
	}


// ===================================
// SET VALUE
// ===================================

	public void SetPref()
	{
		PlayerPrefs.SetInt(prefName, valueToGive);
	}



// END SCRIPT
}
