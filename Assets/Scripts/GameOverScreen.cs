using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text finalScore;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        finalScore.text = "Final Score: " + score;
        Time.timeScale = 0;
    }

    public void Retry()
    {
        SceneManager.LoadScene(0);
        MusicManager.PlayMenuMusic();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
