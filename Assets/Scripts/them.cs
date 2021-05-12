using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class them : MonoBehaviour
{
   // Start is called before the first frame update
    public InputField IDUSER;
    public InputField USERNAME;
    public InputField PASSWORD;
    public InputField LEVEL;
    public InputField POINT;

    string SignUpphp = "http://localhost/php/SignUp.php";
    public void themoi(){

        StartCoroutine(connect());
    }

    IEnumerator connect(){
        WWWForm wf = new WWWForm();
        wf.AddField("id_chuyen",IDUSER.text);
        wf.AddField("user_chuyen",USERNAME.text);
        wf.AddField("pass_chuyen",PASSWORD.text);
        wf.AddField("level_chuyen",LEVEL.text);
        wf.AddField("point_chuyen",POINT.text);

        WWW w = new WWW(SignUpphp ,wf);
        yield return w;
        
        string tam=w.text;
        string tam1=tam.TrimStart();
        string tam11=tam1.TrimEnd();


        if(tam11 == "thanh cong"){
            print("dang nhap thanh cong");
            LoadLogin();
        }
        else{

            print("dang nhap khong thanh cong");
        }

    }
     public void LoadLogin(){
      
    Application.LoadLevel("Scenes/Login");
    
    }

   }
