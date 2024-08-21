using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUIManager : UIManager
{
    public static GameUIManager instance;
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private Transform gameoverPanel;
    [SerializeField] private TextMeshProUGUI finalScore;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void OnPauseButtonClicked()
    {
        Time.timeScale = 0f;
    }

    public void OnResumeButtonClicked()
    {
        Time.timeScale = 1f;
    }

    public void UpdateScore(int points)
    {
        score.text = points.ToString();
    }

    public void ActivateGameOver(int score)
    {
        finalScore.text = "Score: " + score;
        gameoverPanel.gameObject.SetActive(true);
    }
}
