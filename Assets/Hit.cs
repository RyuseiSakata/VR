using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Canvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void onClic(){
        Canvas.SetActive(false);
    }
}
