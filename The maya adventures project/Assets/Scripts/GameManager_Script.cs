using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager_Script : MonoBehaviour
{
    [HideInInspector]
    public int GameScore = 0;
    public Text ScoreText;
    public Text ShadowScoreText;

    private void Start()
    {
        GameScore = 0;
    }

    private void Update()
    {
        ScoreText.text = "S C O R E: " + GameScore;
        ShadowScoreText.text = "S C O R E: " + GameScore;
    }
    public void ReturnButton()
    {
        PlayerPrefs.SetInt("highscore", GameScore);
        SceneManager.LoadScene("MainMenu");
    }
}

