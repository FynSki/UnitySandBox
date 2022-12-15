using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TicTacTime : MonoBehaviour
{
    //boolean
    public bool playerX;
    public bool playerO;
    public bool active;
    public bool winGame;

    // TIME
    public float playerTime;
    public int pointPerSec;
    public float playerRoundTime = 10f;

    // Win Counter
    public int xWinCount;
    public int oWinCount;
    public int drawCount;

    public int fieldCount;
    // Texts
    public Text playerTourTxt;
    public Text timeText;
    public Text winStatementTxt;

    public Text xWinsT;
    public Text oWinsT;
    public Text drawsT;

    public string[] posValue;
    
    public GameObject winScreen;
    public GameObject toDisabled;
    // Start is called before the first frame update
    void Start()
    {
        active = true;
        winGame = false;
        playerO = false;
        playerX = true;
        winScreen.SetActive(false);
        toDisabled.SetActive(true);
        //playerRoundTime = playerTime;
        PrefLoadre();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerTime();
        TextUpdater();
        WinTheGame();
        DrawGame();

    }

    public void WinCondition(int fCell, int sCell, int tCell, string expValue)
    {
        if (string.Equals(posValue[fCell], expValue) && string.Equals(posValue[sCell], expValue) && string.Equals(posValue[tCell], expValue))
        {
            winGame = true;
            winStatementTxt.text = "The winner is: " + expValue;
            winScreen.SetActive(true);
            toDisabled.SetActive(false);
            if (active)
            {
                PrefSetter(expValue);
            }
            active = false;
        }

    }

    public void WinTheGame()
    {
        // X wins
        // winning the game and counting of the wins 
        WinCondition(0, 1, 2, "X");
        WinCondition(3, 4, 5, "X");
        WinCondition(6, 7, 8, "X");
        WinCondition(0, 3, 6, "X");
        WinCondition(1, 4, 7, "X");
        WinCondition(2, 5, 8, "X");
        WinCondition(0, 4, 8, "X");
        WinCondition(2, 4, 6, "X");

        // O wins
        // winning the game and counting of the wins
        WinCondition(0, 1, 2, "O");
        WinCondition(3, 4, 5, "O");
        WinCondition(6, 7, 8, "O");
        WinCondition(0, 3, 6, "O");
        WinCondition(1, 4, 7, "O");
        WinCondition(2, 5, 8, "O");
        WinCondition(0, 4, 8, "O");
        WinCondition(2, 4, 6, "O");
    }

    public void DrawGame()
    {
        //if (fieldCount == 0 && winGame == false)
        if (winGame == false)
        {
            winStatementTxt.text = "Draw";
            //winScreen.SetActive(true);
            if (active)
            {
                drawCount = drawCount + 1;
                PlayerPrefs.SetInt("dCountClassic", drawCount);
            }
            active = false;
        }
    }

    public void ChangeFiledCount(int toDis)
    {
        fieldCount = fieldCount + toDis;
    }

    public void ButtonControler()
    {
        PlayerTime();
        AssigneValue();
        ChangeRound();
    }

    public void PlayerTime()
    {

        //playerRoundTime = playerTime;
        playerRoundTime -= pointPerSec * Time.deltaTime;
        timeText.text = "Time: " + Mathf.Round(playerRoundTime);

        if (playerRoundTime <= 0f)
        {
            ChangeRound();
            playerRoundTime = 10f;
        }
    }

    public void RestartTime()
    {
        playerRoundTime = playerTime;
    }

    public void ChangeRound()
    {
        if (playerO == true)
        {
            playerX = true;
            playerO = false;

        }
        else
        {
            playerO = true;
            playerX = false;
        }
    }

    public string AssigneValue()
    {
        // assigneValue and size
        if (playerO == true)
        {

            return "O";
        }
        else
        {

            return "X";
        }
    }


    public void CheckPosition(int pos, string value)
    {
        posValue[pos] = value;
    }


    public void TextUpdater()
    {
        if (playerX)
        {
            playerTourTxt.text = "X's round";
        }
        if (playerO)
        {
            playerTourTxt.text = "O's round";
        }

        xWinsT.text = "X wins: " + xWinCount;
        oWinsT.text = "O wins: " + oWinCount;
        drawsT.text = "Draws: " + drawCount;

    }


    public void PrefSetter(string expValue)
    {
        if (string.Equals(expValue, "X"))
        {
            xWinCount = xWinCount + 1;
            PlayerPrefs.SetInt("XCountClassic", xWinCount);
        }
        if (string.Equals(expValue, "O"))
        {
            oWinCount = oWinCount + 1;
            PlayerPrefs.SetInt("OCountClassic", oWinCount);
        }
    }

    public void PrefLoadre()
    {
        if (PlayerPrefs.HasKey("XCountClassic"))
        {
            xWinCount = PlayerPrefs.GetInt("XCountClassic");
        }
        if (PlayerPrefs.HasKey("OCountClassic"))
        {
            oWinCount = PlayerPrefs.GetInt("OCountClassic");
        }
        if (PlayerPrefs.HasKey("dCountClassic"))
        {
            drawCount = PlayerPrefs.GetInt("dCountClassic");
        }


    }

    public void ChangeScenne(string gameSceneToChange)
    {
        SceneManager.LoadScene(gameSceneToChange);
    }
}
