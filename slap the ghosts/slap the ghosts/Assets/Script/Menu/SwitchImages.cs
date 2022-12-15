using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchImages : MonoBehaviour {

// =========================================
// ============== ZMIENNE ==================
// =========================================
	public GameObject toOpen;
	public GameObject toClose;

// =========================================

// =========================================
// ============== FUNKCJA ==================
// =========================================

	public void SwitchUI()
	{
		toOpen.SetActive(true);
		toClose.SetActive(false);
		
	}

// =========================================


}
