using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
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
        //Phải
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Time.deltaTime* 2,0,0);
            ani.SetBool("Jump",false);
            ani.Play("begin");
             //Quay đầu
            transform.localScale = new Vector3(3.829387F,3.40177F,0);
        }
        //Trái
         if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Time.deltaTime* 3,0,0);
            ani.SetBool("Jump",false);
            ani.Play("begin");
            //Quay đầu
            transform.localScale = new Vector3(-3.829387F,3.40177F,0);
        }
         //Bay

  if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0,Time.deltaTime* 5,0);
            ani.SetBool("Jump",false);
            ani.Play("jump");
        }

        //Bay qua phải
         if (Input.GetKey(KeyCode.UpArrow)&&Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Time.deltaTime* 5,Time.deltaTime* 10,0);
            ani.SetBool("Jump",false);
            ani.Play("jump");
        }
         //Bay qua trái
         if (Input.GetKey(KeyCode.UpArrow)&&Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Time.deltaTime* 5,Time.deltaTime* 10,0);
            ani.SetBool("Jump",false);
            ani.Play("jump");
        }
    }
}
