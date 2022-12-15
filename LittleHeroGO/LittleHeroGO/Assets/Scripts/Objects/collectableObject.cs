using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableObject : MonoBehaviour {
// ========================================
//
// collectable Objects Script
// version 1.0.2
// date - 2019-08-23
// update - 2019-08-30
// created by Adam Janiszewski
//
// ========================================

// ========================================
//	VARIABLES
// ========================================
	public string tagName;

	private pointAndStatManager pointMgr;
	
	// restoring hp and mana
	public float hpToRestore;
	public float manaToRestore;
	// adding gold
	public int goldToAdd;
	
	// adding dmg phisic and magic and armor
	public float dmgToGive;
	public float phisDmgToGive;
	public float armorToAdd;

	public int minGold;
	public int maxGold;
// ========================================
//	VARIABLES
// ========================================
	void Start () {
		pointMgr = FindObjectOfType<pointAndStatManager>();

		goldToAdd = Random.Range( (minGold) , (pointMgr.distancePoint * maxGold + 1));
	}
	
// ========================================
//	VARIABLES
// ========================================
	public void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			pointMgr.addGold(goldToAdd);
			pointMgr.restoreHpAndMana(hpToRestore, manaToRestore);
			pointMgr.addDmg(dmgToGive);
			pointMgr.addPhisDmg(phisDmgToGive);
			pointMgr.addArmor(armorToAdd);
			this.gameObject.SetActive(false);
		}
		
	}
}
