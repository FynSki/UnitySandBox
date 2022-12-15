using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawn : MonoBehaviour {


// ===================================================
// ==================== VARIABLES ====================
// ===================================================
	[Header("Object creation")]
	public GameObject[] prefabToSpawn;
	[Header("Other options")]
	//public float spawnInterval;

	public float minTime;
	public float maxTime;

	private BoxCollider2D boxCollider2D;
// ===================================================


// ===================================================
// ==================== START ========================
// ===================================================
	void Start ()
	{
		boxCollider2D = GetComponent<BoxCollider2D>();

		StartCoroutine(SpawnObject());
	}
// ===================================================
	

	IEnumerator SpawnObject ()
	{
		while(true)
		{
			// Create some random numbers
			float randomX = Random.Range (-boxCollider2D.size.x, boxCollider2D.size.x) *.5f;
			float randomY = Random.Range (-boxCollider2D.size.y, boxCollider2D.size.y) *.5f;

			// Generate the new object
			GameObject newObject = Instantiate<GameObject>(prefabToSpawn[Random.Range(0,prefabToSpawn.Length)]);
			newObject.transform.position = new Vector2(randomX + this.transform.position.x, randomY + this.transform.position.y);

			// Wait for some time before spawning another object
			yield return new WaitForSeconds(Random.Range(minTime,maxTime));
		}
	}



// END SCRIPT
}
