using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController_Script : MonoBehaviour
{
    public Text HStext;

    private void Start()
    {
        HStext.text = "H I G H S C O R E: " + PlayerPrefs.GetInt("highscore");
    }
    public void StartButton()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
