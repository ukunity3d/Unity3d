using UnityEngine;
using System.Collections;

public class GoBack : MonoBehaviour {


	int score;
    string username = "Player";

	// Use this for initialization
	void Start () {
		updateTheLeaderBoard();
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void updateTheLeaderBoard(){
		
		
		
		score = PlayerPrefs.GetInt("PlayerScore");
		
		Highscores.AddNewHighscore(username,score);
		
		
		Debug.Log("MyScore"+ score);
	
	}
	
	public void Back(){
		
		Application.LoadLevel ("level1");
		
		
	}
}
