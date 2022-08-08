/*
 * Uses Debug.Log to track a bare-bones
 * lives and score system.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 9;

    InGameUI myUI;
    SkinManager skinManager;

    // Start is called before the first frame update
    void Start()
    {
        myUI = GameObject.Find("InGameUI").GetComponent<InGameUI>();
        skinManager = GameObject.Find("SkinManager").GetComponent<SkinManager>();

        skinManager.SetSprite();
    }

    private void Awake()
    {
        MusicManager.PlayGameMusic();
    }
    
    public void AddScore(int value)
    {
        score += value;
        myUI.DisplayScore(score);
        Debug.Log(score);
    }

    public void LoseLife()
    {
        lives -= 1;

        if (lives <= 0)
        {
            myUI.GameOver(score);
            Debug.Log("Game Over");
            return;
        }

        myUI.DisplayLives(lives);
        Debug.Log(lives);
    }
}
