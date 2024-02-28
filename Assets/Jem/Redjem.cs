using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redjem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject field;
    public Field f;
    public int color;

    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        field = GameObject.Find("GameObject");
        f = field.GetComponent<Field>();

        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        f.DeScriaseJem(color);

        //音(sound1)を鳴らす
        audioSource.PlayOneShot(sound1);
    }

}
