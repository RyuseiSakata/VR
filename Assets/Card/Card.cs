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

    void Start(){
    }

//フィールドからカードを消す　新しいカードを追加する
    public void removeThis(int c,int p){
        buy.BuyCard(c,p);
        Destroy(this.gameObject);
    }

    public void getPoint(){}//ポイントを追加する


    /*以下はマウスで動かす用の処理*/
   /* private Vector3 mOffset;
    private float mZCoord;

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }*/
}
