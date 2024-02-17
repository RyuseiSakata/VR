using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour
{
    // Start is called before the first frame update

    public int jemCount = 0;
    public int RedJemCount = 0;
    public int BlueJemCount = 0;
    public int GreenJemCount = 0;
    public int WhiteJemCount = 0;
    public int BlackJemCount = 0;
    public int GetPoint = 0;
    public GameObject gameobject;
    public PlayerContloler pc;

    void Start()
    {

    }

    public void jemFluctuation(){
        jemCount++;
        Debug.Log("jem:"+jemCount);
        pc.Contlorl(0);
        if(jemCount >= 10){
            Debug.Log("勝利(jem)");
        }
    }

    public void RedJemFluctuation(){
        RedJemCount++;
        Debug.Log("Redjem:"+RedJemCount);
        pc.Contlorl(0);

        if(RedJemCount >= 10){
            Debug.Log("勝利(Redjem)");
        }
    }

    public void BlueJemFluctuation(){
        BlueJemCount++;
        Debug.Log("Bluejem:"+BlueJemCount);
        pc.Contlorl(0);

        if(BlueJemCount >= 10){
            Debug.Log("勝利(Bluejem)");
        }
    }

    public void GreenJemFluctuation(){
        GreenJemCount++;
        Debug.Log("Greenjem:"+GreenJemCount);
        pc.Contlorl(0);

        if(GreenJemCount >= 10){
            Debug.Log("勝利(Greenjem)");
        }
    }

    public void WhiteJemFluctuation(){
        WhiteJemCount++;
        Debug.Log("Whitejem:"+WhiteJemCount);
        pc.Contlorl(0);

        if(WhiteJemCount >= 10){
            Debug.Log("勝利(Whitejem)");
        }
    }

    public void BlackJemFluctuation(){
        BlackJemCount++;
        Debug.Log("Blackjem:"+BlackJemCount);
        pc.Contlorl(0);

        if(BlackJemCount >= 10){
            Debug.Log("勝利(Blackjem)");
        }
    }

    public void pointFluctuation(){
        GetPoint++;
        Debug.Log("point:"+GetPoint);
        pc.Contlorl(0);

        if(GetPoint >= 10){
            Debug.Log("勝利(point)");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        

        
    }
}
