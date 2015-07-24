using UnityEngine;
using System.Collections;

public  class GoBack : MonoBehaviour {
	




   
   void Awake(){
			
		SceneManager.playerUserName =(PlayerPrefs.GetString("Player Name"));
		
   }
   

	// Use this for initialization
	void Start () {
		updateTheLeaderBoard();
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void updateTheLeaderBoard(){
		
		
		
		SceneManager.playerScore = PlayerPrefs.GetInt("PlayerScore");
		
		Highscores.AddNewHighscore(SceneManager.playerUserName, SceneManager.playerScore);
		
		Debug.Log("God User Name:" + SceneManager.playerUserName );
		Debug.Log("God user Score:" + SceneManager.playerScore );
	
	}
	
	public void Back(){
	
	
		
		
		Application.LoadLevel ("level1");
		
		
	}
}
