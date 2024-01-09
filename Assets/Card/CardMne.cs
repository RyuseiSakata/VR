using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMne : MonoBehaviour
{
    public List<int> field = new List<int>();
    [SerializeField] private GameObject[] card1;
    [SerializeField] private GameObject[] card2;
    [SerializeField] private GameObject[] card3;
    // Start is called before the first frame update
    void Start()
    {
        field.Add(card1.Length);
        field.Add(20);
        field.Add(30);

        /*for(int i = 0;i < 3;i++){
            SpownCard(i);
        }*/
        GameObject c1 = (GameObject)Instantiate(card1[0], new Vector3(0.0f, 12.0f, 0.0f), Quaternion.identity);
    }

    public void DecriaseCard(int c){
        bool empty = false;
        switch(c){
            case 0:
                field[0] = field[0] - 1;
                if(field[0] <= 0){
                    field[0] = 0;
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
            SpownCard(c);
        }
        else{
            Debug.Log("もうないよ");
        } 
    }
    // Update is called once per frame

    void SpownCard(int c){
        switch(c){
            case 0:
                GameObject c1 = (GameObject)Instantiate(card1[field[0]], new Vector3(0.0f, 3.0f, 0.0f), Quaternion.identity);
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
