using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownScript : MonoBehaviour
{
    public float startTime = 60;
    public float timeRemaining;

    public Text countdownText;
    public ScoreScript myScore;

    private void Start()
    {
        timeRemaining = startTime;
    }

    private void Update()
    {
        if (timeRemaining >= 0)
        {
            timeRemaining -= Time.deltaTime;
            CountdownText((int)timeRemaining);
        }
        else
        {
            myScore.TimeOver();
        }
    }

    void CountdownText(int a)
    {
        countdownText.text = "Zeit: " + a;
    }

    public void IncrementTime(float b)
    {
        if (timeRemaining <= 60)
        {
            timeRemaining = timeRemaining + b;
        }
    }
}
