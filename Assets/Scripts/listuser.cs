using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class listuser : MonoBehaviour
{
    public GameObject rownew;
    string URL="http://localhost/lab3/showuser.php";
    void Start()
    {
        getdata();
    }
    public void getdata(){
        StartCoroutine(connect());   
    }
    IEnumerator connect()
    {
        WWWForm wf = new WWWForm();
        WWW w = new WWW(URL,wf);
        yield return w;
        string data = w.text;
        
        // khai bao mang de luu tru
        string[] a = new string[]{};
        a = data.Split(',');
        // mang a co 4 phan tu
        for(int i=0; i< (a.Length)-1; i++) {

            string line=a[i]  ; 

            string[] b = new string[]{};
            b = line.Split('-');
            // mang b co 5 phan tu
            GameObject g = (GameObject)Instantiate(rownew);
              g.transform.SetParent(this.transform);
              g.transform.Find("id_user").GetComponent<Text>().text=b[0];
              g.transform.Find("user_name").GetComponent<Text>().text=b[1];
              g.transform.Find("pass_word").GetComponent<Text>().text=b[2];
              g.transform.Find("level").GetComponent<Text>().text=b[3];
              g.transform.Find("point").GetComponent<Text>().text=b[4];

        }
        
    }

    
}
