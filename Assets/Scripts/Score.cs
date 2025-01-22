using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score Instance;

    [SerializeField] private TextMeshProUGUI currentScoreText;
    [SerializeField] private TextMeshProUGUI bestText;

    private int score;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    private void Start()
    {
        currentScoreText.text = score.ToString();
        bestText.text = PlayerPrefs.GetInt("Best", 0).ToString();
        UpdateBestScore();

    }
    public void UpdateBestScore()
    {
        if (score > PlayerPrefs.GetInt("Best"))
        {
            PlayerPrefs.SetInt("Best", score);
            bestText.text = score.ToString();


        }
    }

    public void UpdateScore()
    {
        score++;
        currentScoreText.text = score.ToString();
        UpdateBestScore();
    }

}
