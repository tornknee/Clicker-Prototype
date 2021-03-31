using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;


public class Points : MonoBehaviour
{
    private int score = 0;

    public static int increment = 1;

    public int Increment
    {
        get { return increment; }
        set { increment = value; }
    }
    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    [SerializeField]
    public UpgradeClick upgrade;
    public AutoClick auto;
    public Timer timer;

    public TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    /// <summary>
    /// Increases the players score by the increment level of their clicks
    /// </summary>
    public void AddPoints()
    {
        score += increment;
        scoreText.text = score.ToString();
        Score = score;
    }

    /// <summary>
    /// Increases the amount of points that are earned with each click
    /// </summary>
    public void IncreaseIncrement()
    {
        increment += increment;
        score -= upgrade.Cost;
        scoreText.text = score.ToString();
    }

    /// <summary>
    /// Checks if AutoClick toggle is on and if so runs AddPoints once per second for the amount of time specificied by timer
    /// </summary>
    public void AutoOn()
    {
        if (auto.toggle.isOn == true)
        {
            score -= auto.CostAuto;
            scoreText.text = score.ToString();
            InvokeRepeating("AddPoints", 0.1f, 1);
        }
        if (timer.timeLeft <=0)
        {
            CancelInvoke();
        }
    }
}




