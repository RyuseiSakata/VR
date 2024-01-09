using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Card : Card
{
    // Start is called before the first frame update
    private Vector3 posi;

    void Start()
    {
        buyc = GameObject.Find("GameObject");
        buy = buyc.GetComponent<Buy>();
    }

    // Update is called once per frame
    /*void Update()
    {
        posi = this.transform.localPosition;

        if(posi.y < 1){
            removeThis();
        }
        
    }*/

    public void BuyCard(){
        removeThis();
    }

    void OnCollisionEnter(Collision collision)
    {
         removeThis();
    }
}
