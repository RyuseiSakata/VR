using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Card_2 : Card
{
    // Start is called before the first frame update
    private Vector3 posi;

    void Start()
    {
        buyc = GameObject.Find("GameObject");
        buy = buyc.GetComponent<Buy>();
    }

    public void BuyCard(){
    //    removeThis();
    }

    void OnCollisionEnter(Collision collision)
    {
         removeThis(0,1);
    }
}
