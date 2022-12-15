using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMove : MonoBehaviour {
	// ========================================================
	// ===================== ZMIENNE ==========================
	// ========================================================
	private Rigidbody2D myRigidbody;
	
	public float moveSpeed;
	public float minSpeed;
	public float maxSpeed;
	
	public float xDir;
	public float minDir;
	public float maxDir;

	public float yDir;
	public float minDiry;
	public float maxDiry;




	// ========================================================
	// ===================== ZMIENNE ==========================
	// ========================================================
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();

		moveSpeed = Random.Range(minSpeed , maxSpeed);
		xDir = Random.Range(minDir , maxDir);
		yDir = Random.Range(minDiry , maxDiry);

	}
	
	// ========================================================
	// ===================== ZMIENNE ==========================
	// ========================================================
	void Update () {
		myRigidbody.velocity = new Vector3(xDir * moveSpeed , yDir * moveSpeed , 0f );
	}
}
