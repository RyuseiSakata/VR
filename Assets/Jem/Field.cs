using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int red,blue,green,yellow,black;
    [SerializeField] private GameObject redj,bluej,greenj,yellowj,blackj;

    public GameObject player;
    public PlayerClass p;
    void Start()
    {
        player = GameObject.Find("Player");
        p = player.GetComponent<PlayerClass>();
        for(int i = 0;i < 5;i++){
            SpownJem(i);
        }
        red = 5;
        blue = 5;
        green = 5;
        yellow = 5;
        black = 5;
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
                if(blue == 0){
                    SpownJem(c);
                }
                blue++;
                if(blue > 5){
                    blue = 5;
                }
            break;
             case 2:
                if(green == 0){
                    SpownJem(c);
                }
                green++;
                if(green > 5){
                    green = 5;
                }
            break;
             case 3:
                if(yellow == 0){
                    SpownJem(c);
                }
                yellow++;
                if(yellow > 5){
                    yellow = 5;
                }
            break;
             case 4:
                if(black == 0){
                    SpownJem(c);
                }
                black++;
                if(black > 5){
                    black = 5;
                }
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
                    p.RedJemFluctuation();
                    empty = true;
                }
            break;
             case 1:
                blue--;
                GameObject obj2 = GameObject.Find ("Blue(Clone)");
                Destroy(obj2);
                if(blue <= 0){
                    empty = false;
                    blue = 0;
                }
                else{
                    p.BlueJemFluctuation();
                    empty = true;
                }
            break;
             case 2:
                green--;
                GameObject obj3 = GameObject.Find ("Green(Clone)");
                Destroy(obj3);
                if(green <= 0){
                    empty = false;
                    green = 0;
                }
                else{
                    p.GreenJemFluctuation();
                    empty = true;
                }
            break;
             case 3:
                yellow--;
                GameObject obj4 = GameObject.Find ("Yellow(Clone)");
                Destroy(obj4);
                if(yellow <= 0){
                    empty = false;
                    yellow = 0;
                }
                else{
                    p.WhiteJemFluctuation();
                    empty = true;
                }
            break;
             case 4:
                black--;
                GameObject obj5 = GameObject.Find ("Black(Clone)");
                Destroy(obj5);
                if(black <= 0){
                    empty = false;
                    black = 0;
                }
                else{
                    p.BlackJemFluctuation();
                    empty = true;
                }
            break;
        }
        
        if(empty){
            SpownJem(c);
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
                GameObject g = (GameObject)Instantiate(greenj, new Vector3(3.0f, 1.5f, 0.0f), Quaternion.identity);
            break;
             case 3:
                GameObject y = (GameObject)Instantiate(yellowj, new Vector3(6.0f, 1.5f, 0.0f), Quaternion.identity);
            break;
             case 4:
                 GameObject bl = (GameObject)Instantiate(blackj, new Vector3(9.0f, 1.5f, 0.0f), Quaternion.identity);
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
