using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMov : MonoBehaviour {

	// =================================================
	// VARIABLES	
	// =================================================

		// point vatiables
		public GameObject objectToSpawn;
		public string pointTag;

		// ammo
		public string ammoTag;
		public int ammoCount;
		public int ammoToGive;
		public Text ammoCountText;

		//End Game
		public string endGameTag;
		public GameObject endGameInfo;
		
		// Fire button
		public GameObject bulletObject;

		// moving buttons
		private Rigidbody2D myRigid;
		public float moveSpeed;
		public float moveEmpli;

		// player active
		public bool playerAlive;

	// =================================================
	// START
	// =================================================
	void Start () 
	{
		playerAlive = true;
		myRigid = GetComponent<Rigidbody2D>();	
	}
	
	// =================================================
	// UPDATE
	// =================================================
	void Update () 
	{
		// Acceleration
		transform.Translate(Input.acceleration.x, 0, 0);

		// text reload
		ammoCountText.text = "Ammo: " + ammoCount;

		// Moving
		myRigid.velocity = new Vector2( myRigid.velocity.x , (moveSpeed));
	}


	// =================================================
	// ON TRIGGER ENTER
	// =================================================
	void OnTriggerEnter2D(Collider2D other)
    {
		if(playerAlive)
		{
				// Point
				if (other.gameObject.CompareTag(pointTag))
				{
					Instantiate(objectToSpawn, transform.position, transform.rotation);
					other.gameObject.SetActive (false);
				}
				// Ammo
				if(other.gameObject.CompareTag(ammoTag))
				{
					ammoCount = ammoCount + ammoToGive;
					other.gameObject.SetActive(false);
				}
				// EndGame
				if(other.gameObject.CompareTag(endGameTag))
				{
					EndGame();
				}
		}
		


	}

	// =================================================
	// EndGame Func
	// =================================================
	public void EndGame()
	{
		playerAlive = false;
		endGameInfo.SetActive(true);
	}

	// =================================================
	// Fire Button
	// =================================================
	public void FireButton()
	{
		if(ammoCount > 0)
		{
			if(playerAlive)
			{
				Instantiate(bulletObject, transform.position, transform.rotation);
				ammoCount = ammoCount -1;
			}
			
		}
		
	}

	// =================================================
	// Fire Button
	// =================================================

	// moving up
	public void MoveUp()
	{
		moveSpeed = moveSpeed + moveEmpli;
		//transform.Translate (new Vector3(0f, 1f, 0f));
	}

	// moving down
	public void MoveDown()
	{
		moveSpeed = moveSpeed - moveEmpli;
		//transform.Translate (new Vector3(0f, -1f, 0f));
	}



// END SCRIPT

}
