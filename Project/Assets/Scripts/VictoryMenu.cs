using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class VictoryMenu : MonoBehaviour
{
    private int time = 0;
    private int score = 0;
    private int finalScore = 0;

    public TMP_Text timeText;
    public TMP_Text scoreText;
    public TMP_Text finalScoreText;

    void Awake()
    {
        time = PlayerPrefs.GetInt("time");
        score = PlayerPrefs.GetInt("score");
        finalScore = (120 - time) * score;
        timeText.text = time.ToString();
        scoreText.text = score.ToString();
        finalScoreText.text = finalScore.ToString();
    }

    public void Retry()
    {
        SceneManager.LoadScene(1);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
