using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vachammay : MonoBehaviour
{
    private AudioSource source;
    void Start()
    {
                 }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D collider) {
            StartCoroutine("doivaigiay");
           
  }
  IEnumerator doivaigiay(){
    yield return new WaitForSeconds(0.1f);
    Destroy(gameObject);   
  }
}
