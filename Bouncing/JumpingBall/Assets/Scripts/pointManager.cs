using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointManager : MonoBehaviour {

// ========================================
// VARIABLES
// ========================================
	public int pointScore;
	public int hiScore;

	public Text hiScoreText;
	public Text poitScoreText;
// ========================================
// START
// ========================================
	void Start () {
		
		// Hi Score update at start
		// ============= PREF LOADER
		if(PlayerPrefs.HasKey("hiScore"))
		{
			hiScore = PlayerPrefs.GetInt("hiScore");
		}
	}
	
// ========================================
// UPDATE
// ========================================
	void Update () {
		
		// text update
		poitScoreText.text = "Score: " + pointScore;
		hiScoreText.text = "High Score: " + hiScore;

		// ============= HI SCORE
		if(pointScore > hiScore)
		{
			hiScore = pointScore;
			PlayerPrefs.SetInt("hiScore", hiScore);
		}

	}

// ========================================
// ON TRIGGER ENTER
// ========================================

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("PointUI"))
				{
					pointScore = pointScore + 1;
					other.gameObject.SetActive (false);
					
					//StartCoroutine(UiActivator());
				}
	}

// END SCRIPT
}
