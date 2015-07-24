using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class uiManager : MonoBehaviour {
	
	
	public Button[] buttons;
	public Text scoreText;
	private bool gameOver;
	//private int score;
	public Text playerName; //SceneManager
	
	void Awake(){
		
		//Puts Player Name on to screen.
		playerName.text ="Hi:" +  SceneManager.playerUserName; //SceneManager
		
	}

	// Use this for initialization
	void Start () {
	
		gameOver = false;
		SceneManager.playerScore = 0;
		InvokeRepeating("scoreUpdate",1.0f, 0.5f); 
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
		scoreText.text = "Score:" + SceneManager.playerScore;
		
		if(SceneManager.playerScore == 10) {
			Application.LoadLevel("congratulations");
		}
	}
	
	void scoreUpdate(){
	
		
		if (! gameOver){
			SceneManager.playerScore += 1;
			
		}
		
	}
	
	public void gameOverActivated(){
	
	
			
		gameOver = true;
			
			foreach(Button button in buttons){
				button.gameObject.SetActive(true);
			}
		
		
		
	//	SceneManager.playerUserName = (PlayerPrefs.GetString("Player Name"));	
		
	//	PlayerPrefs.SetInt("PlayerScore", SceneManager.playerScore);
		
		
	  
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
	
		//Highscores.AddNewHighscore(SceneManager.playerUserName, SceneManager.playerScore);
		
		
		
		Application.LoadLevel ("menuScene");
	}
	
	public void Exit(){
			
		
		Application.Quit();
	}
	
	
	public void showHighScore(){
		
		Application.LoadLevel ("leaderBoard");
		
				
    }

	public void Back(){
	
		Application.LoadLevel ("level1");
		

    }

	
}