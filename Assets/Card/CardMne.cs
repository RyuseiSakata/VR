using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMne : MonoBehaviour
{
    public List<int> field = new List<int>();
    /*[SerializeField] private GameObject[] card1;
    [SerializeField] private GameObject[] card2;
    [SerializeField] private GameObject[] card3;*/

    [SerializeField] private List<GameObject> card1_R = new List<GameObject>();
    [SerializeField] private List<GameObject> card1_M = new List<GameObject>();
    [SerializeField] private List<GameObject> card1_L = new List<GameObject>();
    [SerializeField] private List<GameObject> card2_R = new List<GameObject>();
    [SerializeField] private List<GameObject> card2_M = new List<GameObject>();
    [SerializeField] private List<GameObject> card2_L = new List<GameObject>();
    [SerializeField] private List<GameObject> card3_R = new List<GameObject>();
    [SerializeField] private List<GameObject> card3_M = new List<GameObject>();
    [SerializeField] private List<GameObject> card3_L = new List<GameObject>();
    private int l,l2,l3,l4,l5,l6,l7,l8,l9,count,count2,count3;
    
    void Start()
    {
        field.Add(card1_R.Count);
        field.Add(card1_M.Count);
        field.Add(card1_L.Count);
        GameObject c1_0 = (GameObject)Instantiate(card1_R[0], new Vector3(0.0f, 5.0f, 0.0f), Quaternion.identity);
        GameObject c1_1 = (GameObject)Instantiate(card1_M[0], new Vector3(2.0f, 5.0f, 0.0f), Quaternion.identity);
        GameObject c1_2 = (GameObject)Instantiate(card1_L[0], new Vector3(4.0f, 5.0f, 0.0f), Quaternion.identity);

        GameObject c2_0 = (GameObject)Instantiate(card2_R[0], new Vector3(6.0f, 5.0f, 0.0f), Quaternion.identity);
        GameObject c2_1 = (GameObject)Instantiate(card2_M[0], new Vector3(8.0f, 5.0f, 0.0f), Quaternion.identity);
        GameObject c2_2 = (GameObject)Instantiate(card2_L[0], new Vector3(10.0f, 5.0f, 0.0f), Quaternion.identity);

        GameObject c3_0 = (GameObject)Instantiate(card3_R[0], new Vector3(12.0f, 5.0f, 0.0f), Quaternion.identity);
        GameObject c3_1 = (GameObject)Instantiate(card3_M[0], new Vector3(14.0f, 5.0f, 0.0f), Quaternion.identity);
        GameObject c3_2 = (GameObject)Instantiate(card3_L[0], new Vector3(16.0f, 5.0f, 0.0f), Quaternion.identity);

        l = card1_R.Count;
        l2 = card1_M.Count;
        l3 = card1_L.Count;

        l4 = card2_R.Count;
        l5 = card2_M.Count;
        l6 = card2_L.Count;

        l7 = card3_R.Count;
        l8 = card3_M.Count;
        l9 = card3_L.Count;
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
            case 3:
               l4 = l4 - 1;
               Debug.Log("aaaaaaa");
               if(l4 <= 0){
                    //l=l2=l3=0;
                    l4 = 0;
                    empty = false;
                }
                else{
                    empty = true;
                }
            break;
            case 4:
               l5 = l5 - 1;
               Debug.Log("aaaaaaa");
               if(l5 <= 0){
                    //l=l2=l3=0;
                    l5 = 0;
                    empty = false;
                }
                else{
                    empty = true;
                }
            break;
            case 5:
               l6 = l6 - 1;
               Debug.Log("aaaaaaa");
               if(l6 <= 0){
                    //l=l2=l3=0;
                    l6 = 0;
                    empty = false;
                }
                else{
                    empty = true;
                }
            break;
            case 6:
               l7 = l7 - 1;
               Debug.Log("aaaaaaa");
               if(l7 <= 0){
                    //l=l2=l3=0;
                    l7 = 0;
                    empty = false;
                }
                else{
                    empty = true;
                }
            break;
            case 7:
               l8 = l8 - 1;
               Debug.Log("aaaaaaa");
               if(l8 <= 0){
                    //l=l2=l3=0;
                    l8 = 0;
                    empty = false;
                }
                else{
                    empty = true;
                }
            break;
            case 8:
               l9 = l9 - 1;
               Debug.Log("aaaaaaa");
               if(l9 <= 0){
                    //l=l2=l3=0;
                    l9 = 0;
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
                GameObject c1 = (GameObject)Instantiate(card1_R[l], new Vector3(0.0f, 5.0f, 0.0f), Quaternion.identity);
            break;
             case 1:
               GameObject c2 = (GameObject)Instantiate(card1_M[l2], new Vector3(2.0f, 5.0f, 0.0f), Quaternion.identity);
            break;
             case 2:
               GameObject c3 = (GameObject)Instantiate(card1_L[l3], new Vector3(4.0f, 5.0f, 0.0f), Quaternion.identity);
            break;
            case 3:
                GameObject c4 = (GameObject)Instantiate(card2_R[l4], new Vector3(6.0f, 5.0f, 0.0f), Quaternion.identity);
            break;
            case 4:
                GameObject c5 = (GameObject)Instantiate(card2_M[l5], new Vector3(8.0f, 5.0f, 0.0f), Quaternion.identity);
            break;
            case 5:
                GameObject c6 = (GameObject)Instantiate(card2_L[l6], new Vector3(10.0f, 5.0f, 0.0f), Quaternion.identity);
            break;
            case 6:
                GameObject c7 = (GameObject)Instantiate(card3_R[l7], new Vector3(12.0f, 5.0f, 0.0f), Quaternion.identity);
            break;
            case 7:
                GameObject c8 = (GameObject)Instantiate(card3_M[l8], new Vector3(14.0f, 5.0f, 0.0f), Quaternion.identity);
            break;
            case 8:
                GameObject c9 = (GameObject)Instantiate(card3_L[l9], new Vector3(16.0f, 5.0f, 0.0f), Quaternion.identity);
            break;
        }
    }

}
