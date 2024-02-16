using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Card : Card
{
    // Start is called before the first frame update
    private Vector3 posi;
    public GameObject player;
    public PlayerClass p;

    void Start()
    {
        buyc = GameObject.Find("GameObject");
        buy = buyc.GetComponent<Buy>();
        player = GameObject.Find("Player");
        p = player.GetComponent<PlayerClass>();
    }

    public void BuyCard(){
    //    removeThis();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(cost[0] <= p.RedJemCount && cost[1] <= p.BlueJemCount &&cost[2] <= p.GreenJemCount &&cost[3] <= p.WhiteJemCount &&cost[4] <= p.BlackJemCount ){
            removeThis(0,0);
            p.pointFluctuation(/*引数に勝利点*/);
        }
    }
}
