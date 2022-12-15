using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour {
// =======================================
// ============= VARIABLES ===============
// =======================================
	public float moveSpeed;
	public float negSpeed;
	private Rigidbody2D movObject;
    public Transform point;
    public Transform point2;
	public bool objPosition;
	

	public float xDir;
	public float yDir;
	public float zDir;

	public float negxDir;
	public float negyDir;
	public float negzDir;
// =======================================

// =======================================
// ============= VARIABLES ===============
// =======================================
	void Start () 
	{
		
		//objPosition = false;
		movObject = GetComponent<Rigidbody2D>();

		// kierunki
	}
// ======================================

// =======================================
// ============= VARIABLES ===============
// =======================================
	void Update () 
	{
		if(movObject.position.y > point.position.y)
		{
			objPosition = false;
			
		}
		if(movObject.position.y < point2.position.y)
		{
			objPosition = true;
		}

	if(objPosition)
	{
			movObject.velocity = new Vector3(xDir * moveSpeed, yDir * moveSpeed, zDir * moveSpeed);
	} else
		{
			movObject.velocity = new Vector3(negxDir * moveSpeed, negyDir * moveSpeed, negzDir * moveSpeed);
		}
		
		
	}
// =======================================


/*
// ========== GÓRA
			if(movObject.position.y < point.position.y)
				{
					//idzie w prawo
					objPosition = false;
				}

		// ========== DÓŁ
			if (movObject.position.y > point2.position.y)
				{
					//idzie w lewo
					objPosition = true;
				}
		
		// ========== KIERUNEK
			if(objPosition)
			{
				movObject.velocity = new Vector2(- speed, movObject.velocity.x);
			}else
			 {
				 movObject.velocity = new Vector2(speed, movObject.velocity.x);
			 }
 */
// END SCRIPT
}
