using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bounce : MonoBehaviour {

// ==================================
// ========= VARIABLES ==============
// ==================================
	// ============== POINT
	public int movePoints;
	public int movePointAdded;
	public int allowToMove;

	
	// ============= POINTS TEXTS
	public Text movePointsText;
	public Text pointsText;
	public Text hiScoreText;

	// =========== GAME OBJECTS
	public GameObject endGameInfo;
	public GameObject textToClose;
	public GameObject objectToSpawn;
	
	// ============== MOVEMENT
	//public bool playerAlive;
	public float jumpForce;
	public float jumpBoost;
	public float moveSpeed;
	public float boostSpeed;
	public float normalSpeed;

	// ============== LAYER MASKS
	public LayerMask whatIsGround;
	public LayerMask whatIsBoosted;
	public LayerMask whatIsSpeeded;
	public bool grounded;
	public bool boosted;
	public bool speeded;
	public bool playerActive;
	public bool activeGround;

	// =============== COMPONENTS
	private Rigidbody2D myRigid;
	private Collider2D myCol;

	// ================ INFORMACYJNE
	public GameObject pointTxt;
	public float timeToActive;

	// ================ SPRITERENDERER
	
    private SpriteRenderer spriteRenderer;
	
	public Sprite normalSprite;
	public Sprite lowMovesSprite;
	public Sprite deadSprite;
	public Sprite increasSpeedSprite;

	public int spriteNr;
	


	// *** End Variables
// ==================================

// ==================================
// ============= START ==============
// ==================================
	void Start () 
	{

	
	//************Przypisanie komponentów***********/
		myRigid = GetComponent<Rigidbody2D>();	
		myCol = GetComponent<Collider2D>();	
		spriteRenderer = GetComponent<SpriteRenderer>();
		
		// bools
		playerActive = true;
		activeGround = false;



	// ************ Sprite start
			

	// *** End Start
	}
// ==================================
	
// ==================================
// ============ UPDATE ==============
// ==================================
	void Update () 
	{
	// ============= Check if touching the ground
		grounded = Physics2D.IsTouchingLayers(myCol, whatIsGround);
		boosted = Physics2D.IsTouchingLayers(myCol, whatIsBoosted);
		speeded = Physics2D.IsTouchingLayers(myCol, whatIsSpeeded);

		
	
	// =============== Sprite Manager

		if(spriteNr == 0)
		{
			spriteRenderer.sprite = deadSprite;
		}
		if(spriteNr == 1)
		{
			spriteRenderer.sprite = normalSprite;
		}
		if(spriteNr == 2)
		{
			spriteRenderer.sprite = lowMovesSprite;
		}
		if(spriteNr == 3)
		{
			spriteRenderer.sprite = increasSpeedSprite;
		}

	// ================================

			// ============= Auto Jump
			if(grounded)
			{
				myRigid.velocity = new Vector2(myRigid.velocity.x, jumpForce);
				allowToMove = 1;
				activeGround = true;
				spriteNr = 1;
			}
			// ============= Boosted
			if(boosted)
			{
				myRigid.velocity = new Vector2(myRigid.velocity.x, jumpBoost);
				allowToMove = 1;
				spriteNr = 3;
				
			}
			
			// ============= Move forward	
			if(movePoints > 0)
			{
				if(allowToMove > 0)
				{
						// ============ SpeedBoost
						if(speeded)
							{
								if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
								{
									myRigid.velocity = new Vector2(boostSpeed, myRigid.velocity.y);
									movePoints = movePoints - 1;
									allowToMove = 0;
									spriteNr = 2;
									
								}
							}else{
								if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
								{
									myRigid.velocity = new Vector2(moveSpeed, myRigid.velocity.y);
									movePoints = movePoints - 1;
									allowToMove = 0;
									
								}


							}
				}
					
			}
			


			
				
			
	// ============= LACK OF MOVE POINTS
		if(movePoints < 1)
		{
			GameOverFun();
		}

	
	
	
	// ============= ???????
	// ============= UI UPDATE
		movePointsText.text = "Moves left: " + movePoints;
		

	

	// *** END UPDATE
	}
// ==================================

// ==================================
// ============ ON TRIGGER ==========
// ==================================
	void OnTriggerEnter2D(Collider2D other)
	{
		// ============ POINTS
		if(other.gameObject.CompareTag("point"))
				{
					other.gameObject.SetActive (false);
					Instantiate(objectToSpawn, transform.position, transform.rotation);
					//StartCoroutine(UiActivator());
				}
		// ============ Player Alive	
		if(other.gameObject.CompareTag("end"))
				{
					//other.gameObject.SetActive (false);
					GameOverFun();
				}
					 
		// ============ MOVE POINT
		if(other.gameObject.CompareTag("movePoint"))
				{
					 other.gameObject.SetActive (false);
					 movePoints = movePoints + movePointAdded;
				}
	
	// *** END OnTriggerEnter	
	}

// ===============================
// =========== END GAME ==========
// ===============================

	public void GameOverFun()
		{
			playerActive = false;
			movePoints = 0;
			jumpForce = 0f;
			moveSpeed = 0f;
			endGameInfo.SetActive(true);
			textToClose.SetActive(false);
			spriteNr = 0;
		// *** End GameOverFun
		}
// ====================================



// ===============================
// =========== END GAME ==========
// ===============================
IEnumerator UiActivator()
    {

           	pointTxt.SetActive(true);
            yield return new WaitForSeconds(timeToActive);
            pointTxt.SetActive(false);
            
	// *** End UI Activator
    }
// ================================

// END SCRIPT
}
