using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMne2 : MonoBehaviour
{
   public List<int> field = new List<int>();
    /*[SerializeField] private GameObject[] card1;
    [SerializeField] private GameObject[] card2;
    [SerializeField] private GameObject[] card3;*/

    [SerializeField] private List<GameObject> card1_R = new List<GameObject>();
    [SerializeField] private List<GameObject> card1_M = new List<GameObject>();
    [SerializeField] private List<GameObject> card1_L = new List<GameObject>();
    private int l,l2,l3,count,count2,count3;
    
    void Start()
    {
        field.Add(card1_R.Count);
        field.Add(card1_M.Count);
        field.Add(card1_L.Count);
        GameObject c1_0 = (GameObject)Instantiate(card1_R[0], new Vector3(6.0f, 5.0f, 0.0f), Quaternion.identity);
        GameObject c1_1 = (GameObject)Instantiate(card1_M[0], new Vector3(8.0f, 5.0f, 0.0f), Quaternion.identity);
        GameObject c1_2 = (GameObject)Instantiate(card1_L[0], new Vector3(10.0f, 5.0f, 0.0f), Quaternion.identity);
        l = card1_R.Count;
        l2 = card1_M.Count;
        l3 = card1_L.Count;
    }

    public void DecriaseCard(int c,int p){
        bool empty = false;
        switch(c){
            case 0:
                //field[0] = field[0] - 1;
                l = l -1;
                if(l <= 0){
                    //l=l2=l3=0;
                    l = 0;
                    empty = false;
                }
                else{
                    empty = true;
                }
            break;
             case 1:
                l2 = l2 - 1;
                Debug.Log("bbbbbbbbb");
                if(l2 <= 0){
                    //l=l2=l3=0;
                    l2 = 0;
                    empty = false;
                }
                else{
                    empty = true;
                }
            break;
             case 2:
               l3 = l3 - 1;
               Debug.Log("aaaaaaa");
               if(l3 <= 0){
                    //l=l2=l3=0;
                    l3 = 0;
                    empty = false;
                }
                else{
                    empty = true;
                }
            break;
        }
        if(empty){
            SpownCard(c,p);
        }
        else{
            Debug.Log("もうないよ");
        } 
    }

    void SpownCard(int n,int p){
        switch(n){
            case 0:
                GameObject c1 = (GameObject)Instantiate(card1_R[l], new Vector3(6.0f, 5.0f, 0.0f), Quaternion.identity);
            break;
             case 1:
               GameObject c2 = (GameObject)Instantiate(card1_M[l2], new Vector3(8.0f, 5.0f, 0.0f), Quaternion.identity);
            break;
             case 2:
               GameObject c3 = (GameObject)Instantiate(card1_M[l3], new Vector3(10.0f, 5.0f, 0.0f), Quaternion.identity);
            break;
        }
    }

}
