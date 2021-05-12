using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator ani;

    void Start()
    {
        ani  = GetComponent<Animator>();     
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Time.deltaTime*1,0,0);
         ani.SetBool("Run",false);
         ani.Play("FrogJump");
    }
}
