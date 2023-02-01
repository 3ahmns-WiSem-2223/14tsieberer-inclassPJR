using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargetScript : MonoBehaviour
{
    [SerializeField]
    private float timePlus = .5f;

    public ScoreScript myScore;
    public CountdownScript myCountdown;

    private void Start()
    {
        this.GetComponent<RectTransform>().anchoredPosition = new Vector2(Random.Range(0, 1820), Random.Range(0, 664.23f));
        HideUnhideTargets(false);
    }

    public void Clicked()
    {
        this.GetComponent<RectTransform>().anchoredPosition = new Vector2(Random.Range(0, 1820), Random.Range(0, 664.23f));
        myCountdown.IncrementTime(timePlus);
        myScore.CountScore();
    }

    public void HideUnhideTargets(bool hidden)
    {
        if(hidden == false)
        {
            this.gameObject.SetActive(true);
            this.GetComponent<RectTransform>().anchoredPosition = new Vector2(Random.Range(0, 1820), Random.Range(0, 664.23f));
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
}
