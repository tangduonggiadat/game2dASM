using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vachamFrog : MonoBehaviour
{
  public AudioSource source;
    public Animator ani;
    
    void Start()
    {
        ani  = GetComponent<Animator>();  
        source = GetComponent<AudioSource>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }  
    void OnTriggerEnter2D(Collider2D collider) {
         
        if(collider.gameObject.tag == "colli-Right"){
            ani.SetBool("Die",false);
            ani.Play("PlayerDie");
            source.Play();
            StartCoroutine("doivaigiay");
            
        }

        if(collider.gameObject.tag == "colli-left"){
             ani.SetBool("Die",false);
             ani.Play("PlayerDie");
              source.Play();
             StartCoroutine("doivaigiay");
               
            
        }

         if(collider.gameObject.tag == "colli-top"){
         GameControlScript.moneyAmount +=5;
             ani.SetBool("FDie",false);
             ani.Play("FrogDie");
             source.Play();
             Destroy(GameObject.Find("frog-idle-1"));   
        }






        /////////////////////////////////

         if(collider.gameObject.tag == "right"){
              ani.SetBool("Die",false);
             ani.Play("PlayerDie");
                source.Play();
             StartCoroutine("doivaigiay");
             
        
            
        }

        if(collider.gameObject.tag == "left"){
             ani.SetBool("Die",false);
             ani.Play("PlayerDie");
              source.Play();
             StartCoroutine("doivaigiay");
               
        
            
        }

         if(collider.gameObject.tag == "to"){
          GameControlScript.moneyAmount +=5;
            ani.SetBool("FDie",false);
            ani.Play("FrogDie");
             source.Play();
          Destroy(GameObject.Find("frog-idle-2"));
        }


  }

  IEnumerator doivaigiay(){
    yield return new WaitForSeconds(0.3f);
    Destroy(GameObject.Find("Player"));    
  }
  
}
