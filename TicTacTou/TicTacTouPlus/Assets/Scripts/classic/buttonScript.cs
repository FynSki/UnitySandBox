using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour
{

    public Button button;
    public Text buttonText;
    public string value;

    public TicTacGameOne gMgr;

    public int curPos;
    
    // Start is called before the first frame update
    void Start()
    {
        gMgr = FindObjectOfType<TicTacGameOne>();
    }

    public void SetFunc()
    {
        
        value = gMgr.AssigneValue();
        gMgr.ChangePlayer();
        buttonText.text = value;
        button.interactable = false;
        gMgr.CheckPosition(curPos , value);
        gMgr.ChangeFiledCount();
    }
}
