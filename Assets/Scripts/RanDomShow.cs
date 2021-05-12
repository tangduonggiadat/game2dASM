using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RanDomShow : MonoBehaviour
{
       public GameObject doituong;
       public GameObject vitri;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(connect());
    }

    // Update is called once per frame
   IEnumerator connect(){
   //Time await
   yield return new WaitForSeconds(4);
   //get vitri tao ra Object
   Vector3 temp= vitri.transform.position;
   temp.x = Random.Range(-12f,12f);
    temp.y = Random.Range(-4f,4f);

   Instantiate(doituong,temp,Quaternion.identity);
   StartCoroutine(connect());

   }
   
}
