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

    void Start()
    {
        
    }

    public void jemFluctuation(){
        jemCount++;
        Debug.Log("jem:"+jemCount);

        if(jemCount >= 10){
            Debug.Log("勝利(jem)");
        }
    }

    public void RedJemFluctuation(){
        RedJemCount++;
        Debug.Log("Redjem:"+RedJemCount);

        if(RedJemCount >= 10){
            Debug.Log("勝利(Redjem)");
        }
    }

    public void BlueJemFluctuation(){
        BlueJemCount++;
        Debug.Log("Bluejem:"+BlueJemCount);

        if(BlueJemCount >= 10){
            Debug.Log("勝利(Bluejem)");
        }
    }

    public void GreenJemFluctuation(){
        GreenJemCount++;
        Debug.Log("Greenjem:"+GreenJemCount);

        if(GreenJemCount >= 10){
            Debug.Log("勝利(Greenjem)");
        }
    }

    public void WhiteJemFluctuation(){
        WhiteJemCount++;
        Debug.Log("Whitejem:"+WhiteJemCount);

        if(WhiteJemCount >= 10){
            Debug.Log("勝利(Whitejem)");
        }
    }

    public void BlackJemFluctuation(){
        BlackJemCount++;
        Debug.Log("Blackjem:"+BlackJemCount);

        if(BlackJemCount >= 10){
            Debug.Log("勝利(Blackjem)");
        }
    }

    public void pointFluctuation(){
        GetPoint++;
        Debug.Log("point:"+GetPoint);

        if(GetPoint >= 10){
            Debug.Log("勝利(point)");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        

        
    }
}
