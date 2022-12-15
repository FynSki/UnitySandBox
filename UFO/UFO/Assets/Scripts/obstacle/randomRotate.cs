using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomRotate : MonoBehaviour {

	// ========================================================
	// ===================== ZMIENNE ==========================
	// ========================================================
	public float zDir;
	public float minRot;
	public float maxRot;
	
	
	// ========================================================
	// ===================== ZMIENNE ==========================
	// ========================================================
	void Start () {
		zDir = Random.Range(minRot , maxRot);
	}
	
	// ========================================================
	// ===================== ZMIENNE ==========================
	// ========================================================
	void Update () {
		transform.Rotate( new Vector3(0 , 0 , zDir) * Time.deltaTime );
	}
}
