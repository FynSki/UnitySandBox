using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerSrc : MonoBehaviour
{
    // ***********************************************
    // VARIABLES
    // ***********************************************
    // Other
    private Rigidbody2D rb2d;
    // Player Stats
    public int startHp;
    public int startMana;

    // Changes Part
    public float currX;
    public float newDist;


    [SerializeField] float moveSpeed;
    [SerializeField] int playerHp;
    [SerializeField] int playerMana;
    [SerializeField] int playerExp;
    [SerializeField] int PlayerLvl;

    // Leveling
    public int nextLvl;


   
    // TMP
    [SerializeField] TextMeshProUGUI playerHpText;
    [SerializeField] TextMeshProUGUI playerManaText;
    [SerializeField] TextMeshProUGUI playerLvlText;
    [SerializeField] TextMeshProUGUI playerExpText;
    [SerializeField] TextMeshProUGUI goldText;
    // Resources
    [SerializeField] int goldCount;

    // Camera
    private CameraScript camCon;

    // ***********************************************
    // Start is called before the first frame update
    // ***********************************************
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        playerMana = startMana;
        playerHp = startHp;

        camCon = FindObjectOfType<CameraScript>();


    }
    // ***********************************************
    // Update is called once per frame
    // ***********************************************
    void Update()
    {
        TextUpdate();
        currX = transform.localPosition.x;
    }

    // ***********************************************
    // FUNCTIONS
    // ***********************************************
    
    // Text update
    public void TextUpdate()
    {
       
        goldText.text = "Gold: " + goldCount.ToString();
        playerHpText.text = "HP: " + playerHp.ToString() + "/" + startHp.ToString();
        playerManaText.text = "Mana: " + playerMana.ToString() + "/" + startMana.ToString();
        playerExpText.text = "Exp: " + playerExp.ToString() + "/" + nextLvl.ToString();
        playerLvlText.text = "Level: " + PlayerLvl.ToString();

    }

    // leveling
    public void nextLevel()
    {
        if(playerExp < nextLvl)
        {
            playerExp = playerExp + (PlayerLvl * playerExp);
            PlayerLvl = PlayerLvl + 1;
        }
    }

    //movement
    public void moveUpFunc()
    {
        rb2d.velocity = new Vector3(0, moveSpeed, 0);
        //rb2d.velocity = new Vector2(rb2d.velocity.x, moveSpeed);
        //transform.Translate(new Vector3(0f, moveSpeed * Time.deltaTime, 0f));
    }
    public void moveDownFunc()
    {
        rb2d.velocity = new Vector3(0, -moveSpeed, 0);
        //rb2d.velocity = new Vector2(rb2d.velocity.x, (moveSpeed * -1f));
        //transform.Translate(new Vector3(0f, -moveSpeed * Time.deltaTime, 0f));
    }
    public void moveRightFunc()
    {
        rb2d.velocity = new Vector3(moveSpeed, 0, 0);
        //rb2d.velocity = new Vector2(rb2d.velocity.y, moveSpeed);
        //transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0f, 0f));
    }
    public void moveLeftFunc()
    {
        rb2d.velocity = new Vector3(-moveSpeed, 0, 0);
        //rb2d.velocity = new Vector2(rb2d.velocity.y, moveSpeed * -1f);
        //transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0f, 0f));
    }
    public void stopMoveFunc()
    {
        rb2d.velocity = new Vector3(0, 0, 0);
        //rb2d.velocity = new Vector2(rb2d.velocity.x, 0f);
    }

    // Actions
    public void attackFunc()
    {

    }

    public void useFunc()
    {

    }
    //On trigger enter
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("CheckPoint"))
        {
            camCon.NewPositionFunc();
            transform.Translate(new Vector3(currX + newDist, 0f, 0f));
        }
    }


        // ***********************************************
        // END SCRIPT
        // ***********************************************
    }
