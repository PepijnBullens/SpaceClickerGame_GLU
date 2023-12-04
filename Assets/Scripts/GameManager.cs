using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // score
    private int score;

    // score text
    [SerializeField] 
    private TextMeshProUGUI scoreText;

    // start
    private void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    // add score
    public void AddScore(int amount)
    {
        if(amount == -1 && score < 1)
        {
            return;
        }

        score += amount;
        scoreText.text = "Score: " + score;
    }
}
