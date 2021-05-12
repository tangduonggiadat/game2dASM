using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour
{
     public Text moneyText;
	public static int moneyAmount;
	int isGunSold;
	public GameObject gun;
	public GameObject cloud;

	// Use this for initialization
	void Start () {
		moneyAmount = PlayerPrefs.GetInt ("MoneyAmount");
		isGunSold = PlayerPrefs.GetInt ("IsGunSold");
		if (isGunSold == 1){
			gun.SetActive (true);
			cloud.SetActive (true);
		}else{
			gun.SetActive (false);
			cloud.SetActive (false);
	}
	}
	
	// Update is called once per frame
	void Update () {
		moneyText.text = "Money: " + moneyAmount.ToString() + "$";
	}
	public void gotoShop()
	{
		PlayerPrefs.SetInt ("MoneyAmount", moneyAmount);
		SceneManager.LoadScene ("ShopScene");
	}
}
