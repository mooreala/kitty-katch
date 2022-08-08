/**
 * Controlls on screen buttons during
 * game play. Updates lives and score text.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
    Text scoreText;
    Text livesText;

    public GameOverScreen gameOverScreen;
    public PauseScreen pauseScreen;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        livesText = GameObject.Find("LivesText").GetComponent<Text>();
        scoreText.text = "Score: 0";
        livesText.text = "Lives: 9";
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void PauseGame()
    {
        Debug.Log("Pause");
        pauseScreen.Setup();

    }

    public void DisplayScore(int points)
    {
        scoreText.text = "Score: " + points;
    }

    public void DisplayLives(int lives)
    {
        livesText.text = "Lives: " + lives;
    }

    public void GameOver(int finalScore)
    {
        gameOverScreen.Setup(finalScore);
        DisplayLives(0);
    }
}
