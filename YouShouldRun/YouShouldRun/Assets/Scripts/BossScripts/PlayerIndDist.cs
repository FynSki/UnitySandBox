using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIndDist : MonoBehaviour
{
    // Created by - Adam Janiszewski
    // version 1.0.0

    // VARIABLES

    private Transform bossObj;
    private Transform playerObj;
    private Transform cameraObj;

    public float bossX;
    public float playerX;
    public float cameraX;

    public float newPos;


    // START
    // Start is called before the first frame update
    void Start()
    {
        findFunc();
    }
    // UPDATE
    // Update is called once per frame
    void Update()
    {
        distanceToPlayer();
        uppdatePossition();

    }
    // FUNCTION
    public void findFunc()
    {
        bossObj = GameObject.FindGameObjectWithTag("Boss").GetComponent<Transform>();
        playerObj = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        cameraObj = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();

    }


    public void distanceToPlayer()
    {
        bossX = bossObj.transform.localPosition.x;
        playerX = playerObj.transform.localPosition.x;
        cameraX = cameraObj.transform.localPosition.x;


    }


    public void uppdatePossition()
    {
        transform.position = new Vector3(cameraX, 2.5f, 0);
    }

    // END SCRIPT
}
