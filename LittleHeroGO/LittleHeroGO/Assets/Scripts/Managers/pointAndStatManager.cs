using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointAndStatManager : MonoBehaviour {

// ========================================
//
// Points and Stats Manager Script
// version 1.1.0
// date - 2019-07-25
// update - 2019-09-03
// created by Adam Janiszewski
//
// ========================================

// ========================================
//	VARIABLES
// ========================================

	// Player Stats
	public float moveSpeed;
	public float jumpForce;

	public float maxMana;
	public float manaPoint;
	public int manaPerSec;
	
	public float playerBaseHp;
	public float playerHp;
	public float playerDmg;
	public float playerPhisicDmg;

	public float playrArmor;
	
	// Points to gather / improve
	public int playerExp;
	public int playerLvl; 
	public int lvlMulti;

	public int nextLevel;
	public int skillPoint;

	public int distancePoint;
	// Texts
	public Text playerExpTxt;
	public Text playerLvlTxt;
	public Text playerHpTxt;
	public Text playerManaText;
	public Text distanceCountText;
	public Text goldCountText;
	public Text armorCoutnText;
	public Text playerMagicDmgText;
	public Text playerPhisicalDmgText;
	

	// Points
	public int goldPoint;
	
	// Add Stats
	public GameObject statButtons;
	public GameObject endGameUI;

	// Texts

// ========================================
//	START
// ========================================
	void Start () {
		playerLvl = 0;

		manaPoint = maxMana;

		playerHp = playerBaseHp;
	}
	
// ========================================
//	UPDATE
// ========================================
	void Update () {
		
	// update functions
		levelCheck();
		
		TextUpdate();

		if(manaPoint < maxMana)
		{
			ManaRegen();
		}

		// Check Player HP
		if(playerHp < 1)
		{
			EndGameFunc();
		}

		// Set Mana and HP to base
		if(playerHp > playerBaseHp)
		{
			playerHp = playerBaseHp;
		}
		if(manaPoint > maxMana)
		{
			manaPoint = maxMana;
		}

	}

// ========================================
//	FUNCTIONS
// ========================================

						// ADD STATS
// ======================================================================
	// ADD HP
	public void addHP(float hpToAdd)
	{
		playerHp = playerHp + hpToAdd;
		playerBaseHp = playerBaseHp + hpToAdd;
		skillPoint = skillPoint - 1;
		if(skillPoint < 1)
		{
			statButtons.SetActive(false);
		}
		
	}

	// ADD SPEED
	public void addSpeed(float speedToAdd)
	{
		moveSpeed = moveSpeed + speedToAdd;
		skillPoint = skillPoint - 1;
		if(skillPoint < 1)
		{		
			statButtons.SetActive(false);
		}
		
	}

	// ADD FORCE
	public void addForce(float jumpToAdd)
	{
		jumpForce = jumpForce + jumpToAdd;
		skillPoint = skillPoint - 1;
		if(skillPoint < 1)
		{
			statButtons.SetActive(false);
				
		}
		
	}

	// ADD MANA
	public void addMana(int manaToAdd)
	{
		maxMana = maxMana + manaToAdd;
		skillPoint = skillPoint - 1;
		if(skillPoint < 1)
		{
			statButtons.SetActive(false);
				
		}
		
	}

// ======================================================================
	// ADD EXPERIANCE
	public void addExp(int extTpAdd)
	{
		playerExp = playerExp + extTpAdd;
	}

	// ADD DAMAGE
	public void addDmg(float dmgToGive)
	{
		playerDmg = playerDmg + dmgToGive;
	}

	// ADD PHIS DMG
	public void addPhisDmg(float phisDmgToGive)
	{
		playerPhisicDmg = playerPhisicDmg + phisDmgToGive;
	}

	// ADD DISTANCE
	public void addDistance(int distanceToAdd)
	{
		distancePoint = distancePoint + distanceToAdd;
	}

	// ADD GOLD
	public void addGold(int goldToAdd)
	{
		goldPoint = goldPoint + goldToAdd;
	}

	// RESTOLE HP and MANA
	public void restoreHpAndMana(float hpToRestore, float manaToRestore)
	{
		manaPoint = manaPoint + manaToRestore;
		playerHp = playerHp + hpToRestore;
	}

	// Add Armor
	public void addArmor(float armorToAdd)
	{
		playrArmor = playrArmor + armorToAdd;
	}


// ======================================================================	
	// Player Received DMG
	public void PlayerRecDmgFunc(float dmgReceived)
	{
		if(playrArmor > 0)
		{
			playrArmor = playrArmor - 10;
		}
		else
		{
			playerHp = playerHp - dmgReceived;
		}
		
	}


// ======================================================================
	// PLAYER LEVEL CHECK
	public void levelCheck()
	{
		if(playerExp > ( (200 * (playerLvl + 1) ) * (playerLvl + 1) ))
		{
			
			playerLvl = playerLvl + 1;
			skillPoint = skillPoint + 1;
			statButtons.SetActive(true);
			//playerExp = 0;
		}

		nextLevel = 200*(playerLvl + 1) * (playerLvl + 1);

		if(playerLvl > 1)
		{
			lvlMulti = playerLvl - 1;
			
		}
	}

// ======================================================================	
	// Mana Resource
	public void MissManaFunc(float manaCosts)
	{
		manaPoint = manaPoint - manaCosts;
	}

	public void ManaRegen()
	{
		manaPoint += manaPerSec * Time.deltaTime;
	}


// ======================================================================
	// TEXT UPDATE
	public void TextUpdate()
	{
		playerExpTxt.text = "Exp: " + playerExp  + "/" + nextLevel;
		playerLvlTxt.text = "LvL: " + playerLvl;
		playerHpTxt.text = "HP: " + playerHp + "/" + playerBaseHp;
		playerManaText.text = "Mana: " + Mathf.Round(manaPoint) + "/" + maxMana;
		distanceCountText.text = "Distance: " + distancePoint;
		goldCountText.text = "$: " + goldPoint;
		armorCoutnText.text = "Armor: " + playrArmor + "/100";
		playerMagicDmgText.text = "Magic: " + playerDmg;
		playerPhisicalDmgText.text = "Damage: " + playerPhisicDmg;
		
	}

// ======================================================================
	// END GAME FUNCTION
	public void EndGameFunc()
	{
		// Set Values to 0
		moveSpeed = 0f;
		jumpForce = 0f;
		playerHp = 0f;

		// Active EndGame UI
		endGameUI.SetActive(true);


	}

// ======================================================================
// END SCRIPT
// ======================================================================
}
