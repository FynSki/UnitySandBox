using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeDeactiveUi : MonoBehaviour {

// =============================================
// VARIABLES
// =============================================
	public GameObject ActiveUi;
	public GameObject DeactiveUi;

// =============================================
// VARIABLES
// =============================================
	void Start () {
		
	}
	
// =============================================
// VARIABLES
// =============================================
	void Update () {
		
	}
// =============================================
// ACTIVE
// =============================================
	public void ActiveUiFunc()
	{
		ActiveUi.SetActive(true);
	}

// =============================================
// DEACTIVE
// =============================================

	public void DeactiveUiFunc()
	{
		DeactiveUi.SetActive(false);
	}

// =============================================
// Active and Deactive
// =============================================

	public void SwitchUiFunc()
	{
		ActiveUi.SetActive(true);
		DeactiveUi.SetActive(false);
	}


// END SCRIPT
}
