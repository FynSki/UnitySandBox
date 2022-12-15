using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointManager : MonoBehaviour {

// ==========================================
// VARIABLES
// ==========================================
	// ints
	public int pointCount;
	public int highPointCount;

	// time
	public float totalTime;
	public int pointPerSec;

	public float highTotalTime;

	// tags
	public string pointTagName;
	public string highScoreText;
	public string highTotalTimeTag;

	// text presentation
	public Text pointCountText;
	public Text highPointText;
	public Text timeText;
	public Text hiTotalTimeText;

	// Player Mov
	private playerMov playerObj;
	public bool playerAlive;

// ==========================================
// START
// ==========================================
	void Start () {
		
		// Player
		playerObj = FindObjectOfType<playerMov>();

		// player pref download
		if(PlayerPrefs.HasKey(highScoreText))
					{
						highPointCount = PlayerPrefs.GetInt(highScoreText);
					}
		
	
		if(PlayerPrefs.HasKey(highTotalTimeTag))
					{
						highTotalTime = PlayerPrefs.GetFloat(highTotalTimeTag);
					}
	}
	
// ==========================================
// UPDATE
// ==========================================
	void Update () {
		playerAlive = playerObj.playerAlive;
		
		// time
		if(playerAlive)
		{
			totalTime +=  pointPerSec * Time.deltaTime;
		}
		

		// High Score
		if (highPointCount < pointCount)
		{
			highPointCount = pointCount;
			PlayerPrefs.SetInt(highScoreText , highPointCount);
		}

		if (highTotalTime < totalTime)
		{
			highTotalTime = totalTime;
			PlayerPrefs.SetFloat(highTotalTimeTag , highTotalTime);
		}


		// text update
		pointCountText.text = "Point: " + pointCount;
		highPointText.text = "High Point: " + highPointCount;
		timeText.text = "Time: " + Mathf.Round (totalTime);
		hiTotalTimeText.text = "Best Time: " + Mathf.Round (highTotalTime);
	}

// ==========================================
// ON TRIGGER ENTER 2D
// ==========================================
	void OnTriggerEnter2D(Collider2D other)
    {
		// point to add
		if (other.gameObject.CompareTag(pointTagName))
        {
			pointCount = pointCount + 1;
			other.gameObject.SetActive (false);
		}
	}

// END SCRIPT
}
