using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountingPoint : MonoBehaviour
{
    public static CountingPoint instance;
    [SerializeField] TextMeshProUGUI scoreUI;
    [SerializeField] TextMeshProUGUI highscoreUI;
    int score = 0;
    int highscore = 0;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreUI.text = score.ToString();
        highscoreUI.text = highscore.ToString();
    }
    public void onCountingPoint(int p)
    {
        score += p;
        scoreUI.text = score.ToString();
        if (highscore < score)
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore", score);
        }
    }
}
