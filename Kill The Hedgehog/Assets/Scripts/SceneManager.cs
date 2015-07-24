using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {



	#region STATIC VARIABLES
	public static int playerScore;
	public static string playerUserName;
	#endregion
	
	
	//STATIC FUNCTION
	public static void LeaderBoard(string playerUserName){
	
	 Debug.Log("The Player Name is: " + playerUserName);
	}
}
