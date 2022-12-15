using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour {
// ========================================================
// ===================== ZMIENNE ==========================
// ========================================================
	private Rigidbody2D myRigidbody;
	public float moveSpeed;
	public float xDir;
	public float yDir;
	public float zDir;
// ========================================================

// ========================================================
// ===================== UPDATE ===========================
// ========================================================
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
	}
// ========================================================

// ========================================================
// ===================== UPDATE ===========================
// ========================================================
	void Update () {
		myRigidbody.velocity = new Vector3(xDir * moveSpeed , yDir * moveSpeed , zDir * moveSpeed );
	}
// ========================================================


// END SCRIPT
}
