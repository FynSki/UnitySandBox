﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToObject : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody2D myRigid;

	public string tagToMove;

	private Transform target;
	// Use this for initialization
	void Start () {
		myRigid = GetComponent<Rigidbody2D>();
		target = GameObject.FindGameObjectWithTag(tagToMove).GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards(transform.position , target.position , moveSpeed * Time.deltaTime);
	}
}
