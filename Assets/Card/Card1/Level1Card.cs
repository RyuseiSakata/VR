using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Card : Card
{
    // Start is called before the first frame update
    void Start()
    {
        buyc = GameObject.Find("GameObject");
        buy = buyc.GetComponent<Buy>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyCard(){
        removeThis();
    }

      void OnCollisionEnter(Collision collision)
    {
         removeThis();
    }
}
