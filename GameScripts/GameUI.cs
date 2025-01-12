using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{

    public TMP_Text scoreText;

    int score;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    public void AddScore()
    {
        //score = score + 1;
        score++;
        scoreText.text = score.ToString();
    }
}
