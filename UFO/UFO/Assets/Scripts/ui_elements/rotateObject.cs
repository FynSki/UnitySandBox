using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour {

	public int xDir;
	public int yDir;
	public int zDir;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate( new Vector3(xDir , yDir , zDir) * Time.deltaTime );

	}
}
