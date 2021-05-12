using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Login : MonoBehaviour
{
    public InputField USERNAME;
    public InputField PASSWORD;

    string dangnhapphp = "http://localhost/php/Login.php";
    public void login(){
        StartCoroutine(connect());
    }

    IEnumerator connect(){
        WWWForm wf = new WWWForm();
        wf.AddField("user_chuyenn", USERNAME.text);
        wf.AddField("pass_chuyenn", PASSWORD.text);

        WWW w = new WWW(dangnhapphp, wf);
        yield return w;

        string tam = w.text;
        string tam1 = tam.TrimStart();
        string tam11 = tam1.TrimEnd();

        if (w.text == "Ngon")
        {
            print("Thanh cong");
            StartLevel();
        }else
        {
            print("Xui roi");
        }
        
    }

    public void StartLevel(){
        Application.LoadLevel("Menu");
    }

}