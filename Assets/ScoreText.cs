using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScoreText : MonoBehaviour
{
    public Card card;
    public int cPoint;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "SCORE:0";
    }

    // Update is called once per frame
    void Update()
    {
        cPoint = card.point;
        scoreText.text = "SCORE:" + cPoint;
    }
}
