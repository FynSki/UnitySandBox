using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemySpawn : MonoBehaviour {
// ========================================
//
// Random Enemy Spawn Script
// version 1.0.0
// date - 2019-08-18
// created by Adam Janiszewski
//
// ========================================

// ========================================
//	VARIABLES
// ========================================

	public GameObject[] enemyToSpawn;
	

// ========================================
//	START
// ========================================
	void Start () {
		Instantiate(enemyToSpawn[Random.Range(0,enemyToSpawn.Length)], transform.position, transform.rotation);
		this.gameObject.SetActive(false);
	}
	
// ========================================
//	UPDATE
// ========================================
	void Update () {
		
	}
}
