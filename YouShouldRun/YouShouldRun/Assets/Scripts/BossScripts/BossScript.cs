using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{   // Created by - Adam Janiszewski
    // version 1.0.0

    // VARIABLES
        private Rigidbody2D myRigid;
        public float moveSpeed;

    // START
    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
    }
    // UPDATE
    // Update is called once per frame
    void Update()
    {
        MovingFunc();
    }

    // FUNCTIONS
    public void MovingFunc()
    {
        myRigid.velocity = new Vector3(moveSpeed, 0, 0);
    }



    // END SCRIPT
}
