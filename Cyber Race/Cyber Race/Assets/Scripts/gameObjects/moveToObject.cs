using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToObject : MonoBehaviour {

// ==========================================
// VARIABLES
// ==========================================
	public float moveSpeed;
	//private Rigidbody2D myRigid;
	private Transform target;

	public string objToFollowtag;

// ==========================================
// START
// ==========================================
	void Start () {

		//myRigid = GetComponent<Rigidbody2D>();
		target = GameObject.FindGameObjectWithTag("PointManager").GetComponent<Transform>();
	}
	
// ==========================================
// UPDATE
// ==========================================
	void Update () {


		transform.position = Vector2.MoveTowards(transform.position , target.position , moveSpeed * Time.deltaTime);
	}

// ===========================================
// END SCRIPT
}
