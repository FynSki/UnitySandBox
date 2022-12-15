using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follower : MonoBehaviour {

// ====================================
// =========== VARIABLES ==============
// ====================================
	public Transform loader;
	public float speed;
// ====================================
	void Start () {
		
	}
	

	void Update () {
		transform.LookAt(loader);
		transform.Translate(speed*Vector3.forward*Time.deltaTime);
	}
}
