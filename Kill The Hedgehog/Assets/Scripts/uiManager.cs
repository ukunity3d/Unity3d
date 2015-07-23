using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
public class uiManager : MonoBehaviour {

	public Button[] buttons;
	public Text scoreText;
	bool gameOver;
	private int score;
	string username = "Player";
	//private TextMesh myscoreText;
	
	void Awake(){
		
		scoreText.text = "Score: " + PlayerPrefs.GetInt("PlayerScore");
		
		//Debug.Log("Problems" + score);
	
	}

	// Use this for initialization
	void Start () {
	gameOver = false;
	score = 0;
	InvokeRepeating("scoreUpdate",1.0f, 0.5f); 
	
	
	}
	
	// Update is called once per frame
	void Update () {
	scoreText.text = "score:" + score;
	}
	
	void scoreUpdate(){
	
		
		if (! gameOver){
		score += 1;
			
		}
		
	}
	
	public void gameOverActivated(){
	
			if (score > PlayerPrefs.GetInt("PlayerScore")){
				PlayerPrefs.SetInt("PlayerScore", score);
			}
			
			gameOver = true;
			
			foreach(Button button in buttons){
				button.gameObject.SetActive(true);
			}
		PlayerPrefs.SetInt("PlayerScore", score);
		
	  
	}
	
	public void Play(){
	
	Application.LoadLevel("level1");
	}
	
	public void Pause(){
	
		if  (Time.timeScale == 1) {
			Time.timeScale = 0;
	}
	    else if (Time.timeScale == 0){
		   Time.timeScale = 1;
	}
}

	
	
	public void Menu(){
		
		Application.LoadLevel ("menuScene");
	}
	public void Exit(){
	
		Application.Quit();
	}
	
	
	public void showHighScore(){
		
		Application.LoadLevel ("highScore");
		
		
		
}

	public void Back(){
	
		Application.LoadLevel ("level1");
		

}

	
}