using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redjem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject field;
    public Field f;

    void Start()
    {
        field = GameObject.Find("GameObject");
        f = field.GetComponent<Field>();
    }

    void OnCollisionEnter(Collision collision)
    {
         f.DeScriaseJem(0);
    }

}
