using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBackGround : MonoBehaviour {

// ===================================================
// ==================== VARIABLES ====================
// ===================================================
	public GameObject[] backgroundImeges;

	public float waitTimeCounter;
	public float waitTimeMin;
	public float waitTimeMax;

	public bool spawned;
	public int spawnNum;

	private BoxCollider2D boxCollider2D;
// ===================================================
// ==================== VARIABLES ====================
// ===================================================
	void Start () {
		//InvokeRepeating( "InstaObj" , waitTime , timeBetwen); // 
		waitTimeCounter = Random.Range(waitTimeMin , waitTimeMax);
		spawned = true;

		boxCollider2D = GetComponent<BoxCollider2D>();
	}
	
// ===================================================
// ==================== VARIABLES ====================
// ===================================================
	void Update () {
		if(spawned)
		{
			waitTimeCounter -= Time.deltaTime;
			
			if(waitTimeCounter < 0f)
			{
				InstaObj();
				spawned = false;
				waitTimeCounter = Random.Range(waitTimeMin , waitTimeMax);
			}
		}
		else
		{
			waitTimeCounter -= Time.deltaTime;
			if(waitTimeCounter < 0f)
			{
				spawnNum = 1;
				spawned = true;
				waitTimeCounter = Random.Range(waitTimeMin , waitTimeMax);

			}
		}


	// END UPDATE	
	}

// ===================================================
// ==================== VARIABLES ====================
// ===================================================

	public void InstaObj()
	{
		while(spawnNum > 0)
		{
			float randomX = Random.Range (-boxCollider2D.size.x, boxCollider2D.size.x) *.5f;
			float randomY = Random.Range (-boxCollider2D.size.y, boxCollider2D.size.y) *.5f;

			GameObject newObject = Instantiate<GameObject>(backgroundImeges[Random.Range(0,backgroundImeges.Length)]);

			newObject.transform.position = new Vector2(randomX + this.transform.position.x, randomY + this.transform.position.y);

			//Instantiate(backgroundImeges[Random.Range(0,backgroundImeges.Length)], transform.position, transform.rotation);
			spawnNum = spawnNum -1;
		}
		
	}

// End Script
}
