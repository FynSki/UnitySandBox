using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour {

// ========================================
// VARIABLES
// ========================================

	// POINTS
	public int pointScore;
	public int hiPointScore;

	public int powerUpPoint;
	
	// TEXT DISPLAY
	public Text pointText;
	public Text hiScoreText;
	public Text TimeLeftText;
	public Text BoostPointText;

	// STRINGS
	public string HiScorePrefString;
	// TIME CALCULATOR
		public int pointPerSec;
		// FLOATS
		public float timeToEnd;
	// Find Player OBJ
	private player_mov PlayerMovement;


// ========================================
// START
// ========================================
	void Start () {
		
		// downliad Hi Score pref
		if(PlayerPrefs.HasKey(HiScorePrefString))
		{
			hiPointScore = PlayerPrefs.GetInt(HiScorePrefString);
		}
		// ================================

		// Find Player
		PlayerMovement = FindObjectOfType<player_mov>();


	}
	
// ========================================
// UPDATE
// ========================================
	void Update () {
		
		// test display 
		pointText.text = "Point: " + pointScore;
		hiScoreText.text = "Hi Score: " + hiPointScore;
		TimeLeftText.text = "Time: " + Mathf.Round(timeToEnd);
		BoostPointText.text = "Power: " + powerUpPoint;

		// ================================ */

		// Hi Score check
		if(pointScore > hiPointScore)
		{
			hiPointScore = pointScore;
			PlayerPrefs.SetInt(HiScorePrefString , hiPointScore);
		}
		// ================================

		// TIME CALCULATOR
		
			timeToEnd -= pointPerSec * Time.deltaTime;
		
		
		// ================================

		// End on time
		 
		if(timeToEnd < 0f)
		{
			PlayerMovement.PlayerLost();
			pointPerSec = 0;	
		}
		//*/

	}


// ========================================
// FUNCTION GIVE POINT
// ========================================
	public void GivePoint( int pointToGive)
	{
		pointScore = pointScore + pointToGive;
	}
	// END FUNCTION
// ========================================
// FUNCTION GIVE TIME
// ========================================
	public void GiveTime ( float timeToGive)
	{
		timeToEnd = timeToEnd + timeToGive;
	}
	// END FUNCTION
// ========================================
// FUNCTION POWER UP POINTS
// ========================================
	public void GivePowerUp ( int powerToGive)
	{
		powerUpPoint = powerUpPoint + powerToGive; 
	}
	// END FUNCTION



// ========================================
// END SCRIPT
// ========================================
}
