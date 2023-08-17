using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TMPro.Examples;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText ;
    int score;
   
    
    void Start(){
        score = 0;
        
    }

    public void UpdateScore(int gainedScore){
        Debug.Log("Update atempt");
        score += gainedScore;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        Debug.Log("trying to update score ui");
        scoreText.text = "Score:" + score.ToString();
    }    
}
