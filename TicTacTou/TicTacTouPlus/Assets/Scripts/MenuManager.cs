using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public string gameSceneToChange;

    

    public void OpenUI(GameObject uiToOpen)
    {
        uiToOpen.SetActive(true);
    }

    public void CloseUI(GameObject uiToClose)
    {
        uiToClose.SetActive(false);
    }

    public void ChooseType(int gameNo)
    {
        PlayerPrefs.SetInt("GameNo", gameNo);
        SceneManager.LoadScene(gameSceneToChange);
    }
}
