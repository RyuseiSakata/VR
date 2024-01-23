using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMne : MonoBehaviour
{
    public List<int> field = new List<int>();
    [SerializeField] private GameObject[] card1;
    [SerializeField] private GameObject[] card2;
    [SerializeField] private GameObject[] card3;

    [SerializeField] private List<GameObject> card1_1 = new List<GameObject>();
    private int l,l2,l3,count,count2,count3;
    // Start is called before the first frame update
    void Start()
    {
        field.Add(card1_1.Count);
        field.Add(20);
        field.Add(30);
        l=field[0]-2;
        l2=field[0]-1;
        l3=field[0];
        GameObject c1_0 = (GameObject)Instantiate(card1[0], new Vector3(0.0f, 5.0f, 0.0f), Quaternion.identity);
        GameObject c1_1 = (GameObject)Instantiate(card1[1], new Vector3(2.0f, 5.0f, 0.0f), Quaternion.identity);
        GameObject c1_2 = (GameObject)Instantiate(card1[2], new Vector3(4.0f, 5.0f, 0.0f), Quaternion.identity);
        //field[0] = field[0] - 3;
        count=count2=count3 = field[0]/3;
    }

    public void DecriaseCard(int c,int p){
        bool empty = false;
        switch(c){
            case 0:
                //field[0] = field[0] - 1;
                if(p == 0){
                   l=l-3;
                   count=count-1;
                }
                else if(p == 1){
                    l2=l2-3;
                    count2=count2-1;
                }
                else{
                   l3=l3-3;
                   count3=count3-1;
                }
                if(count <= 0&&count2<=0&&count3<=0){
                    l=l2=l3=0;
                    empty = false;
                }
                else{
                    empty = true;
                }
            break;
             case 1:
                field[1] = field[1] - 1;
            break;
             case 2:
               field[2] = field[2] - 1;
            break;
        }
        if(empty){
            SpownCard(c,p);
        }
        else{
            Debug.Log("もうないよ");
        } 
    }
    // Update is called once per frame

    void SpownCard(int l,int p){
        switch(l){
            case 0:
                if(p == 0){
                    GameObject c1 = (GameObject)Instantiate(card1[l], new Vector3(0.0f, 5.0f, 0.0f), Quaternion.identity);
                }
                else if(p == 1){
                    GameObject c1 = (GameObject)Instantiate(card1[l2], new Vector3(2.0f, 5.0f, 0.0f), Quaternion.identity);
                }
                else{
                    GameObject c1 = (GameObject)Instantiate(card1[l3], new Vector3(4.0f, 5.0f, 0.0f), Quaternion.identity);
                }
            break;
             case 1:
               GameObject c2 = (GameObject)Instantiate(card2[field[1]], new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
            break;
             case 2:
               GameObject c3 = (GameObject)Instantiate(card3[field[2]], new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
            break;
        }
    }

}
