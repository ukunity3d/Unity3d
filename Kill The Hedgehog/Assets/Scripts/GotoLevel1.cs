using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class GotoLevel1 : MonoBehaviour {


	

	[SerializeField] private InputField _userField;

	
	
public	void GotoLevel(){
		
		SceneManager.playerUserName = _userField.text;
		
		
		PlayerPrefs.SetString("Player Name", SceneManager.playerUserName);
		
		SceneManager.playerUserName = SceneManager.playerUserName; //SceneManager
		
		
		
		
		Application.LoadLevel("level1");
	}
}
