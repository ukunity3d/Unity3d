using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class uiCongratulations : MonoBehaviour {


public Text playerScore;

	// Use this for initialization
	void Start () {
		playerScore.text = SceneManager.playerUserName;
		StartCoroutine(LoadNextLevel());
	}
	
	
	
	
	IEnumerator LoadNextLevel() {
		//print(Time.time);
		yield return new WaitForSeconds(5);
		//print(Time.time);
		
		Application.LoadLevel("level2");
	}
	
}
