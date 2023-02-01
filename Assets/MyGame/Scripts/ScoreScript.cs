using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private int score;

    [SerializeField]
    private int highscore = 0;

    public Text scoreText;
    public Text yourScoreText;
    public Text highscoreText;
    public TargetScript myTarget1;
    public TargetScript myTarget2;
    public TargetScript myTarget3;
    public CountdownScript myCountdown;

    private void Start()
    {
        yourScoreText.gameObject.SetActive(false);
        highscoreText.gameObject.SetActive(false);
        highscore = 0;
        score = 0;
        scoreText.text = "Score: " + score;
    }

    public void CountScore()
    {
        score = score + 1;
        scoreText.text = "Score: " + score;
    }

    public void TimeOver()
    {
        myTarget1.HideUnhideTargets(true);
        myTarget2.HideUnhideTargets(true);
        myTarget3.HideUnhideTargets(true);
        yourScoreText.text = "Your Score: " + score;
        yourScoreText.gameObject.SetActive(true);

        if(score > highscore)
        {
            highscore = score;
        }

        highscoreText.text = "Highscore: " + highscore;
        highscoreText.gameObject.SetActive(true);
    }

    public void Restart()
    {
        myCountdown.timeRemaining = myCountdown.startTime;
        yourScoreText.gameObject.SetActive(false);
        highscoreText.gameObject.SetActive(false);
        score = 0;
        scoreText.text = "Score: " + score;
        myTarget1.HideUnhideTargets(false);
        myTarget2.HideUnhideTargets(false);
        myTarget3.HideUnhideTargets(false);
    }
}
