using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSceene : MonoBehaviour {

// =======================================
// ================ VARIABLE =============
// =======================================
	public string nextSceen;
// =======================================
	
// =======================================
// ================ VARIABLE =============
// =======================================
	  public void ChangeSceen()
    {
        SceneManager.LoadScene(nextSceen);
    }
// =======================================

// END SCRIPT
}
