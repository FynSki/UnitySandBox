using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTypeManager : MonoBehaviour
{
    public int gameNo;
    public GameObject[] toActive;

    // Start is called before the first frame update
    void Start()
    {
        PrefLoader();
        SetGameType();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrefLoader()
    {
        if (PlayerPrefs.HasKey("GameNo"))
        {
            gameNo = PlayerPrefs.GetInt("GameNo");
        }
    }

    public void SetGameType()
    {
        toActive[gameNo].SetActive(true);
    }
}
