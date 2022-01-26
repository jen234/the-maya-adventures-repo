using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    // Public Variable
    public Text scoreDisplay;
    public bool shouldReset = false;
    public int winningScore = 1000;

    // Private variables
    private static int scoreValue = 0;

    void Start()
    {

        if(shouldReset == true)
        {
            // Reset the score value back to 0
            scoreValue = 0;
        }

        // Update the display of the score based on the numerical
        scoreDisplay.text = scoreValue.ToString();
    }

    // Function to add to the player's score
    public void AddScore(int toAdd)
    {
        // Update the numerical value of the score (Action 1)
        scoreValue = scoreValue + toAdd;

        // Update the display of the score based on the numerical
        scoreDisplay.text = scoreValue.ToString();

        if (scoreValue >= winningScore)
        {
            SceneManager.LoadScene("Winner");
        }
    }
}
