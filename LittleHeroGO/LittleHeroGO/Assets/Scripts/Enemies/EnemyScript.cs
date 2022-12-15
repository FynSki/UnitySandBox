using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
// ========================================
//
// Enemy Script
// version 1.0.6
// date - 2019-08-16
// update - 2019-09-04
// created by Adam Janiszewski
//
// ========================================

// ========================================
//	VARIABLES
// ========================================
	private pointAndStatManager pointMgr;
	// enemy stats
		// base Stats
		public float baseEnemyHp;
		public int baseEnemyExp;
	
		public float enemyHp;
		public float enemyArmor;

		public float dmgDealToPlayer;
		public float dmgReceived;

	// enemy worth
	public int extTpAdd;
	public int goldToAdd;

	public GameObject[] lootToSpawn;

	// enemy Hp system
	public GameObject[] enemyHealtBar;

// ========================================
//	START
// ========================================
	void Start () {
		

		pointMgr = FindObjectOfType<pointAndStatManager>();

		// base stats
		enemyHp = baseEnemyHp + ( (pointMgr.distancePoint * 2) + baseEnemyHp);
		extTpAdd = baseEnemyExp + (baseEnemyExp + ( pointMgr.distancePoint * 2) ) ;
		dmgReceived = dmgDealToPlayer + (dmgDealToPlayer + (pointMgr.distancePoint * 2) ) ;
		
	}
	
// ========================================
//	UPDATE
// ========================================
	void Update () {
		
		if(enemyHp < 1)
		{
			EnemyIsKilled();
		}

	}

// ========================================
//	FUNCTIONS
// ========================================
	public void EnemyIsKilled()
	{

		pointMgr.addExp(extTpAdd);
		//pointMgr.addGold(goldToAdd);
		lootFunction();
		this.gameObject.SetActive(false);

	}

	public void checkHpStats()
	{
		if(enemyHp < ((baseEnemyHp + (pointMgr.distancePoint * baseEnemyHp)) * 0.75f))
		{
			enemyHealtBar[3].SetActive(false);
		}
		// 50-75
		if(enemyHp < ((baseEnemyHp + (pointMgr.distancePoint * baseEnemyHp)) * 0.5f))
		{
			enemyHealtBar[2].SetActive(false);
		}
		// 25-50
		if(enemyHp < ((baseEnemyHp + (pointMgr.distancePoint * baseEnemyHp)) * 0.25f))
		{
			enemyHealtBar[1].SetActive(false);
		}

	}

	public void lootFunction()
	{
		Instantiate(lootToSpawn[Random.Range(0,lootToSpawn.Length)], transform.position, transform.rotation);
	}

// ========================================
//	ON TRIGGER ENTER
// ========================================
	void OnTriggerEnter2D(Collider2D other)
	{
		// Player Fire Ball
		if(other.gameObject.CompareTag("fireBall"))
		{
			enemyHp = enemyHp - pointMgr.playerDmg;
			other.gameObject.SetActive(false);
			checkHpStats();
		}

		// HIT PLAYER                 
		if(other.gameObject.CompareTag("Player"))
		{
			pointMgr.PlayerRecDmgFunc(dmgReceived);
			enemyHp = enemyHp - pointMgr.playerPhisicDmg;
			checkHpStats();
		}

	}



// END SCRIPT
}
