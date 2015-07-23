﻿using UnityEngine;
using System.Collections;

public class carSpawner : MonoBehaviour {
	int carNo;
	public GameObject[] cars;
	public float maxPos = 2.4f;
	public float delayTimer = 2f;
	float timer;
	

	// Use this for initialization
	void Start () {
	timer = delayTimer;	
	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if( timer <= 0){
		
		//	Vector3 carPos = new Vector3(Random.Range(-2.4f, 2.4f), transform.position.y, transform.position.z);
		Vector3 carPos = new Vector3(Random.Range(-2.4f, 2.4f), transform.position.y, transform.position.z);
		
		// car number 5 never shows
		carNo = Random.Range(0,5);
		Instantiate(cars[carNo], carPos, transform.rotation);
		timer = delayTimer;
		}
	}
}
