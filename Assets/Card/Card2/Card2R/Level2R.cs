using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2R : Card
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
         removeThis(3,0);
    }
}
