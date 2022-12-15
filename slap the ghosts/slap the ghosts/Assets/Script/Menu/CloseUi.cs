using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseUi : MonoBehaviour {

// ====================================
// VARIABLES 
// ====================================

	public GameObject UiToClose;

// ===================================
// Close UI Func
// ===================================

	public void CloseUiFunc()
	{
		UiToClose.SetActive(false);
	}

// END SCRIPT
}
