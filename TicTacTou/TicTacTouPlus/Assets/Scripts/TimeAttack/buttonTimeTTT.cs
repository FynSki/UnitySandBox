using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonTimeTTT : MonoBehaviour
{
    public Button button;
    public Text buttonText;
    public int curPos;
    public string value;
    public int counter;


    public TicTacTime gMgr;
    // Start is called before the first frame update
    void Start()
    {
        gMgr = FindObjectOfType<TicTacTime>();
    }

    // Update is called once per frames
    void Update()
    {
        
    }


    public void SetValue(string valueToSet , int fieldCountInt)
    {
        value = valueToSet;
        buttonText.text = value;
        //gMgr.ChangeRound();
        gMgr.ChangeFiledCount(fieldCountInt);
        gMgr.CheckPosition(curPos , value);
        gMgr.RestartTime();
    }



    public void PrintValue()
    {

        counter = gMgr.fieldCount;

        if (counter > 0)
        {
            if (gMgr.playerX == true)
            {
                SetValue("X", -1);
                gMgr.ChangeRound();

            }
            else
            {
                SetValue("O", -1);
                gMgr.ChangeRound();
            }
        }
        else if(counter <= 1)
        {
            if (string.Equals(value, "X") && gMgr.playerX == true)
            {
                SetValue("", 1);
            }
            else if (string.Equals(value, "O") && gMgr.playerO == true)
            {
                SetValue("", 1);
            }
            /*
            else if (string.Equals(value, ""))
            {
                //gMgr.ChangeFiledCount(-1);
                value = gMgr.AssigneValue();
                gMgr.ChangeRound();
                buttonText.text = value;
                gMgr.CheckPosition(curPos, value);
            } */
            //value = "!!!";
            //buttonText.text = value;
        }

        
        
    }
}
