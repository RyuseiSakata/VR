using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScoreText : MonoBehaviour
{
    public Card card;
    public int cPoint;
    public Text scoreText;

    public Text jemText;
    public PlayerClass playerClass;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "SCORE:0";
    }

    // Update is called once per frame
    void Update()
    {
        // cPoint = card.point;
        // scoreText.text = "SCORE:" + cPoint;
        // Debug.Log("cpoint:"+cPoint +"     "+"point:"+card.point);
        // Debug.Log("cpoint:"+cPoint +"     "+"point:"+card.point);

        scoreText.text = "SCORE:" + playerClass.GetPoint;

        jemText.text = "RED:"+playerClass.RedJemCount+"  " + "BLUE:"+playerClass.BlueJemCount+"  " + 
                            "GREEN:"+playerClass.GreenJemCount+"  " + "WHITE:"+playerClass.WhiteJemCount+"  " +
                                "BLACK:"+playerClass.BlackJemCount;
    }
}
