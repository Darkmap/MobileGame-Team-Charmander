﻿using UnityEngine;
using System.Collections;

public class StartSceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void quitClick(){
		Debug.Log ("clicked");
		Application.Quit ();
	}
	public void changeBattleScene(){
		Application.LoadLevel("BattleScene");

	}
}
	