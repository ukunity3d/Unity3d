using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {
	public float carSpeed;
	public float maxPos = 2.4f;
	
	Vector3 position;
	public uiManager ui;

	// Use this for initialization
	void Start () {
	
		
		position = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		
		
	
	
		Ray ray = Camera.main.ScreenPointToRay ( Input.mousePosition );	
		
		transform.position = new Vector3(ray.GetPoint(0f).x, -2.64f , transform.position.z);
		
		;
		
	}
	
	void OnCollisionEnter2D(Collision2D col){
	
		if (col.gameObject.tag == "Enemy Car") {
			Destroy (gameObject);
			ui.gameOverActivated();
		}
		
	}
}
