using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    void Start()
    {
        // Note still got error if run from scene game over in unity because it didn't have ScoreKeeper Object
        if (scoreKeeper.GetScore() != 0) 
        {
            scoreText.text = scoreKeeper.GetScore().ToString();
        }
        else
        {
            scoreText.text = "0";
        }
    }

}
