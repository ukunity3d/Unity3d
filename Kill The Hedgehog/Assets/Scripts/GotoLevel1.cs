using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class GotoLevel1 : MonoBehaviour {
	
	//public string inputUserName;
	//private string test;
	
//	private Text inputUserName;
	
//	private Text InputUserDetails;
//	private GameObject inputUserNameGo;
//	private Text inputUserNameCo;
	
//	public GameObject initialsObject;
//	InputField initialsField;
//	Text initialsFieldInput;
	
	
public	void GotoLevel(){

	//	initialsField = inputUserName.GetComponent<InputField>();
		
	//	initialsFieldInput = initialsField.GetComponent<Text>();
	//	Debug.Log(initialsFieldInput.text);
	

	
		
	//InputUserName =	InputUserDetails.text;
	
	//	Debug.Log("UserName: " + InputUserName);
		
	//	PlayerPrefs.SetString("PlayerUserName", "InputUserName");
	
		// inputUserNameGo = GameObject.Find("InputUserName");
		// inputUserNameCo = inputUserNameGo.GetComponent<InputField>();
		 
	//	inputUserNameCo = GameObject.Find("inputUserName").GetComponent<InputField>();
	//	inputUserNameCo = GameObject.Find("inputUserName").GetComponent<Text>();//.text;
	//	Debug.Log("inputUserNameCo");
	//	print(inputUserNameCo);
	//	PlayerPrefs.SetString("PlayerUserName", "inputUserNameCo");
	//	PlayerPrefs.Save();
		//test = PlayerPrefs.GetString("inputUserNameCo");
	//	Debug.Log(PlayerPrefs.GetString("inputUserNameCo")); //+ " has a score of: " +  PlayerPrefs.GetInt(i + "HScore"));
	   // Debug.Log(test);
	   
	   
		Application.LoadLevel("level1");
	}
}
