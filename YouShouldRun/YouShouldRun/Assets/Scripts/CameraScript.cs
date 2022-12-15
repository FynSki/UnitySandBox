using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // ***********************************************
    // VARIABLES
    // ***********************************************
    public float currX;
    public float newDist;

    // ***********************************************
    // START
    // ***********************************************
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // ***********************************************
    // UPDATE
    // ***********************************************
    // Update is called once per frame
    void Update()
    {
        currX = transform.localPosition.x;
    }

    // ***********************************************
    // FUNCTIONS
    // ***********************************************
    public void NewPositionFunc()
    {
        //transform.Translate(new Vector3(currX + newDist, 0f , 0f));
        transform.Translate(new Vector3(newDist, 0f, 0f));
    }


    // END SCRIPT
}
