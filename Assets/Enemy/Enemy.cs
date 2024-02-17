using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameobject;
    public PlayerContloler pc;
    void Start()
    {
        Debug.Log("敵の動きだよ～～");
        pc.Contlorl(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
