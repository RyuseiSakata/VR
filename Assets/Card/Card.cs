using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    // Start is called before the first frame update
    public int winpoint;
    public int[] cost = new int[5]; //赤　青　黄色　緑　黒

    public GameObject buyc;
    public Buy buy;

    public int point;
    // private int testPoint;

    void Start()
    {
        point = 1;
    }

//フィールドからカードを消す　新しいカードを追加する
    public void removeThis(int c,int p){
        buy.BuyCard(c,p);
        getPoint();
        // Destroy(this.gameObject);
    }

    public void getPoint(){
        // testPoint += 1;
        point += 1;
        Debug.Log("point:"+point);
        // Debug.Log("point:"+testPoint);
    }//ポイントを追加する

}
