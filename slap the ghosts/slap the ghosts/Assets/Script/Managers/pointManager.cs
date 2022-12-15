using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointManager : MonoBehaviour {
// ========================================
// 			POINT MANAGER
// 		main point manager - need to be 
//		assigned to an object
//		*********************************
//		contains all points and functions 
//		that can be used by other scripts
// 
// ========================================

// ========================================
//				VARIABLES
// ========================================
	// floats for Points - points are time related
	public float currentPoints;
	public float hiScore;
	// Points for curage
	public int curragePoint;
	public GameObject currageBar;


	
	// floats for Time counting
	public float currentTime;
	public float bestTime;
	public float pointPerSec;

	// Text 
	public Text currentTimeText;
	public Text bestTimeText;
	public Text currentPointText;
	public Text hiScoreText;
	public Text currageText; // need to remove - only for test


	// end game objects - needed for EndGame func
	public GameObject endGameUI;
	public GameObject ghostSpawnObj;
	public bool gameOn;


// ========================================
//				START
// ========================================
	void Start () {
		
		// Set gameOn bool to true
		gameOn = true;

	
		// load hiScore and Best Time from playerPrefs
		PlayerPrefsLoader();
	
	// END START
	}
	
// ========================================
//				UPDATE
// ========================================
	void Update () {
		
		// Time
		currentTime += pointPerSec * Time.deltaTime;
		//update texts
		TextDisplay();
		// update hiScore & bestTime
		if(currentPoints > hiScore)
		{
			hiScore = currentPoints;
			PlayerPrefs.SetFloat("hiScore" , hiScore);
			//add player prefs
		}
		
		// best Time
		if(currentTime > bestTime)
		{
			bestTime = currentTime;
			PlayerPrefs.SetFloat("BestTime" , bestTime);
			//add player prefs
		}
		

		// update scareBarr

		// End Game
		if(curragePoint < 1)
		{
			EndGame();
			curragePoint = 0;
		}

		// Curage update
		if(curragePoint > 100)
		{
			curragePoint = 100;
		}

	// END UPDATE
	}

// ========================================
//				fUNKCJON
// ========================================

	// ADD POITN FUNCT
	public void AddPoints(float pointsToAdd , float timeToAdd)
	{
	
			currentPoints = currentPoints + pointsToAdd;
	

	}

	// REMOVE POINT FUNC
	public void RemovePoint(float timeToRemove)
	{
	
			currentTime = currentTime - timeToRemove;
		
		
	}
	

	// ADD Curage
	public void AddCurage(int curageToAdd)
	{
		if(curragePoint < 100)
		{
			curragePoint += curageToAdd;
		}
			
	}

	// SCARE BAR FUNC
	public void ScarreBar(int curageToRemove)
	{
		if(gameOn)
		{
			curragePoint -= curageToRemove;
		}
		else{
			curragePoint = 0;
		}
		
	}

	// END GAME FUNCTION
	//
	//		when Game has ended: 
	//		1. end game UI set to active
	//		2. time - pointPerSec set to 0f
	//		3. gameOn set to false
	//		4. ghost Spawns set to false - in order to stop producing ghost
	//			need to be checked - there will be more then 1 ghostSpawn
	//			- Maybe create script that will be asigned to ghostSpawn
	//				that check gameOn in pointManager;
	//
	public void EndGame()
	{
		endGameUI.SetActive(true);
		pointPerSec = 0f;
		gameOn = false;
		ghostSpawnObj.SetActive(false);
	}

	// TEXT FUNC
	void TextDisplay()
	{
		// Text Update
		currentTimeText.text = "Time: " + Mathf.Round(currentTime);
		currentPointText.text = "Points: " + (currentPoints);
		hiScoreText.text = "Best Score: " + (hiScore);
		
		// courage text will be replaced by bar
		currageText.text = "Courage: " + curragePoint;
		bestTimeText.text = "Best Time: " + Mathf.Round(bestTime);
	}

	
	//
	// Player Prefs Loader
	// need to be invoke in Start()
	//
	public void PlayerPrefsLoader()
	{
		// PlayerPrefs for Best Time - name can be set in Variables later
		if(PlayerPrefs.HasKey("BestTime"))
		{
			bestTime = PlayerPrefs.GetFloat("BestTime");
		}

		// PlayerPrefs for best score - name can be set in variables later
		if(PlayerPrefs.HasKey("hiScore"))
		{
			hiScore = PlayerPrefs.GetFloat("hiScore");
		}
	}

// END FUNCTIONS	

// 	END SCRIPT	
}
