using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adding : MonoBehaviour
{
    // Start is called before the first frame update
int count =0;

public Text text_diem;
public void UpdateScore(){
 
count++;
text_diem.text ="Score:"+count;

}  
}
