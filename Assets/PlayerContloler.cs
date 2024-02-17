using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContloler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public PlayerClass p;
    public GameObject enemy;
    public Enemy e;

    void Start()
    {
        //player = GameObject.Find("Player");
        //p = player.GetComponent<PlayerClass>();
        //enemy = GameObject.Find("Enemy");
        //e = enemy.GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Contlorl(int pnum){
        switch(pnum){
            case 0:
            player.SetActive(false);
            enemy.SetActive(true);
            break;
            case 1:
            player.SetActive(true);
            enemy.SetActive(false);
            break;
        }
    }
}
