using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryWin : MonoBehaviour
{
    private AudioSource source;
    // Start is called before the first frame update public Animator ani;
    void Start()
    {
              source = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D collider) {
            source.Play();
            gameObject.GetComponent<Collider2D> ().enabled=false;
            StartCoroutine("doivaigiay");
           
  }
  IEnumerator doivaigiay(){
    yield return new WaitForSeconds(0.1f);
    Destroy(gameObject);   
    GameControlScript.moneyAmount +=2; 
  }
}
