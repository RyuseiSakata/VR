using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameobject;
    public PlayerContloler pc;
    void Start()
    {
        /*Debug.Log("敵の動きだよ～～");
        if(Random.Range(1,10)==9){
            Debug.Log("敵のkatidayo～～");
        }
        pc.Contlorl(1);*/
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("敵の動きだよ～～");
        if(Random.Range(1,10)==9){
        // if(Random.Range(1,2)==1){
            Debug.Log("敵のkatidayo～～");
            SceneManager.LoadScene("Lose");
        }
        pc.Contlorl(1);
    }
}
