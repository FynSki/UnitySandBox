using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NaviButtons : MonoBehaviour {
// ========================================
//
// Navi Buttons Script Script
// version 1.0.1
// date - 2019-08-20
// update - 
// created by Adam Janiszewski
//
// ========================================
	
// ========================================
// VARIABLES
// ========================================
	

// ========================================
// NAVI BUTTONS FUNCTIONS
// ========================================

	public void SwitchSceeneFunc(string newSceen)
	{
		SceneManager.LoadScene(newSceen);
	}

	public void ExitGame()
	{
		Application.Quit();
	}



}
