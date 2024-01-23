using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    private Field field;
    private CardMne card;
    // Start is called before the first frame update
    [SerializeField] private GameObject mane;
    void Start()
    {
        mane = GameObject.Find("GameObject");
        field = mane.GetComponent<Field>();
        card = mane.GetComponent<CardMne>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BuyCard(int c,int p){
        if(card.field[0] != 0){
            field.IncriaseJem(c);
            card.DecriaseCard(c,p);
        }
    }
}
