using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int red,blue,green,yellow,black;
    [SerializeField] private GameObject redj,bluej,greenj,yellowj,blackj;
    void Start()
    {
        
        for(int i = 0;i < 5;i++){
            SpownJem(i);
        }
        red = 5;
    }

    public void IncriaseJem(int c){
        switch(c){
            case 0:
                if(red == 0){
                    SpownJem(c);
                }
                red++;
                if(red > 5){
                    red = 5;
                }
            break;
             case 1:
                blue++;
            break;
             case 2:
                green++;
            break;
             case 3:
                yellow++;
            break;
             case 4:
                black++;
            break;
        }
    }

    public void DeScriaseJem(int c){
        bool empty = false;
        switch(c){
            case 0:
                red--;
                GameObject obj = GameObject.Find ("Red(Clone)");
                Destroy(obj);
                if(red <= 0){
                    empty = false;
                    red = 0;
                }
                else{
                    empty = true;
                }
            break;
             case 1:
                blue--;
            break;
             case 2:
                green--;
            break;
             case 3:
                yellow--;
            break;
             case 4:
                black--;
            break;
        }
        
        if(empty){
            SpownJem(c);
            Debug.Log(red);
        }
    }

    void SpownJem(int c){
        //以下にプレハブから指定のオブジェクトを作り出す処理をかく.
        
        switch(c){
            case 0:
                GameObject r = (GameObject)Instantiate(redj, new Vector3(-2.0f, 1.5f, 0.0f), Quaternion.identity);
            break;
             case 1:
                GameObject b = (GameObject)Instantiate(bluej, new Vector3(1.5f, 1.5f, 0.0f), Quaternion.identity);
            break;
             case 2:
                GameObject g = (GameObject)Instantiate(greenj, new Vector3(2.0f, 1.5f, 0.0f), Quaternion.identity);
            break;
             case 3:
                GameObject y = (GameObject)Instantiate(yellowj, new Vector3(3.0f, 1.5f, 0.0f), Quaternion.identity);
            break;
             case 4:
                 GameObject bl = (GameObject)Instantiate(blackj, new Vector3(4.0f, 1.5f, 0.0f), Quaternion.identity);
            break;
        }
    }

    public void OnClick(){
        DeScriaseJem(0);
    }

    public void LostJem(){
        IncriaseJem(0);
    }
}
